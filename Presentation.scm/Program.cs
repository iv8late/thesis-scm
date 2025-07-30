using Business.scm.Courses;
using Business.scm.LessonContent;
using DTO.scm;
using Mapping.scm;
using Utility.scm;
using Utility.scm.Interfaces;
using Utility.scm.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton(typeof(Cache<>));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ILessonContentService, LessonContentService>();

var app = builder.Build();

DataSeeder.SeedThemes(app.Services);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
