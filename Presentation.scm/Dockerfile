# Imagen base para ejecutar la app (Linux, no nanoserver)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Imagen para compilar
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Presentation.scm/Presentation.scm.csproj", "Presentation.scm/"]
RUN dotnet restore "./Presentation.scm/Presentation.scm.csproj"
COPY . .
WORKDIR "/src/Presentation.scm"
RUN dotnet build "./Presentation.scm.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publicar la app
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Presentation.scm.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Imagen final (ligera para producción)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Presentation.scm.dll"]
