using System;
using System.Collections.Generic;
using DTO.scm;
using Microsoft.Extensions.DependencyInjection;
using Utility.scm.Repositories;

namespace Mapping.scm
{
    public static class DataSeeder
    {
        public static void SeedThemes(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var cache = scope.ServiceProvider.GetRequiredService<Cache<ThemeDTO>>();

            var themes = new List<ThemeDTO>
            {
                new ThemeDTO
                {
                    Id = 1,
                    Title = "Angular",
                    Description = "Description Angular, TypeScript...",
                    Courses = new List<CourseDTO>
                    {
                        new CourseDTO
                        {
                            Id = 101,
                            Title = "Console errors",
                            Description = "Learn meanings of the most common console errors",
                            StageId = 1,
                            ThemeId = 1,
                            Lessons = new List<LessonDTO>
                            {
                                new LessonDTO
                                {
                                    Id = 1001,
                                    Title = "Form errors",
                                    Description = "Form",
                                    Order = 1,
                                    StageId = 1,
                                    LessonContents =
                                    [
                                        new LessonContentDTO { Id = 10001, LessonId = 1001, TypeId = 1, Order = 1, Content = "{\n    \"title\": {\n      \"en\": \"Introduction to Angular\",\n      \"es\": \"Introducción a Angular \"\n    },\n    \"textContents\": {\n      \"concept\": {\n        \"en\": \"Angular is a **framework** for building web applications, based on components.\",\n        \"es\": \"Angular es un **marco de trabajo** para la realización de aplicaciones web, basado en componentes. \"\n      },\n      \"introduction\": {\n        \"en\": \"Let\'s get familiar with the basic concepts.\",\n        \"es\": \"Vamos a familiarizarnos con los conceptos bases.  \"\n      },\n      \"contents\": [\n        {\n          \"en\": \"A **component** is a part or element that is part of a larger whole.\",\n          \"es\": \"Un **componente** es una parte o elemento que forma parte de un todo más grande.\"\n        },\n        {\n          \"en\": \"In Angular, a component is made up of 3 types of files\",\n          \"es\": \"En Angular el componente se conforma de 3 elementos/tipos de archivos.\"\n        },\n        {\n          \"en\": \"CSS, HTML, and TS.\",\n          \"es\": \"CSS, HTML, Y TS. \"\n        },\n        {\n          \"en\": \"HTML structures the page of a website\",\n          \"es\": \".html es el archivo que permite estructura el cuerpo de la página web\"\n        },\n        {\n          \"en\": \"CSS is the file that adds styles to the HTML.\",\n          \"es\": \".css es el archivo que le da estilos al .html\"\n        },\n        {\n          \"en\": \"And the TS file contains the logic that gives functionality to the HTML.\",\n          \"es\": \"y el .ts contiene la lógica que permite al html tener funcionalidad.\"\n        }\n      ]\n    },\n    \"imageUrl\": \"link\",\n    \"backgroundColor\": \"#FFF3E0\",\n    \"audioUrl\": \"link\",\n    \"avatar\": {\n      \"name\": \"Lina\",\n      \"imageUrl\": \"link\",\n      \"position\": \"bottomLeft\"\n    },\n    \"vocabulary\": [\n      {\n        \"term\": \"component\",\n        \"definition\": {\n          \"es\": \"Una parte reutilizable de una aplicación Angular que contiene HTML, CSS y lógica (TS).\",\n          \"en\": \"A reusable part of an Angular app containing HTML, CSS, and logic (TS).\"\n        }\n      },\n      {\n        \"term\": \"framework\",\n        \"definition\": {\n          \"es\": \"Una estructura que facilita el desarrollo de software.\",\n          \"en\": \"A structure that helps in building software applications.\"\n        }\n      },\n      {\n        \"term\": \"npm\",\n        \"definition\": {\n          \"es\": \"Gestor de paquetes de Node.js para instalar herramientas.\",\n          \"en\": \"Node.js package manager used to install tools.\"\n        }\n      },\n      {\n        \"term\": \"Node.js\",\n        \"definition\": {\n          \"es\": \"Entorno que permite ejecutar JavaScript fuera del navegador.\",\n          \"en\": \"Environment that allows JavaScript to run outside the browser.\"\n        }\n      }\n    ]\n  }" },
                                        new LessonContentDTO { Id = 10002, LessonId = 1001, TypeId = 1, Order = 2, Content = " {\n    \"title\": {\n      \"en\": \"Installing Angular\",\n      \"es\": \"Instalación de Angular\"\n    },\n    \"textContents\": {\n      \"introduction\": {\n        \"en\": \"Before creating a project, we need to get familiar with these concepts.\",\n        \"es\": \"Antes de crear un proyecto. Debemos conocer familiarizarnos con estos conceptos \"\n      },\n      \"contents\": [\n        {\n          \"en\": \"To install Angular, Node.js is required—it\'s the JavaScript runtime environment.\",\n          \"es\": \"Pues instalar Angular se necesita Node.js, el entorno de ejecución de JavaScript\"\n        },\n        {\n          \"en\": \"Let\'s look at the following analogy.\",\n          \"es\": \"Veamos la siguiente analogía.\"\n        }\n      ],\n      \"table\": [\n        {\n          \"element\": {\n            \"en\": \"JavaScript\",\n            \"es\": \"JavaScript\"\n          },\n          \"analogy\": {\n            \"en\": \"🔧 The language used to build the car\",\n            \"es\": \"🔧 El lenguaje para construir carros\"\n          },\n          \"description\": {\n            \"en\": \"The programming language\",\n            \"es\": \"Es el lenguaje de programación\"\n          }\n        },\n        {\n          \"element\": {\n            \"en\": \"Node.js\",\n            \"es\": \"Node.js\"\n          },\n          \"analogy\": {\n            \"en\": \"🚗 The car engine\",\n            \"es\": \"🚗 El motor del carro\"\n          },\n          \"description\": {\n            \"en\": \"Executes JavaScript outside the browser\",\n            \"es\": \"Ejecuta JavaScript fuera del navegador\"\n          }\n        },\n        {\n          \"element\": {\n            \"en\": \"npm\",\n            \"es\": \"npm\"\n          },\n          \"analogy\": {\n            \"en\": \"🛒 The parts store\",\n            \"es\": \"🛒 La tienda de repuestos\"\n          },\n          \"description\": {\n            \"en\": \"Installs tools like Angular\",\n            \"es\": \"Instala herramientas como Angular\"\n          }\n        },\n        {\n          \"element\": {\n            \"en\": \"Angular CLI\",\n            \"es\": \"Angular CLI\"\n          },\n          \"analogy\": {\n            \"en\": \"⚙️ A tool you install to work on the car\",\n            \"es\": \"⚙️ Una herramienta que compras para mejorar el carro\"\n          },\n          \"description\": {\n            \"en\": \"A utility to work with Angular projects\",\n            \"es\": \"Una utilidad para trabajar con proyectos Angular\"\n          }\n        }\n      ]\n    },\n    \"vocabulary\": [\n      {\n        \"term\": \"npm\",\n        \"definition\": {\n          \"es\": \"Gestor de paquetes de Node.js para instalar herramientas.\",\n          \"en\": \"Node.js package manager, used to install tools.\"\n        }\n      },\n      {\n        \"term\": \"Node.js\",\n        \"definition\": {\n          \"es\": \"Entorno que permite ejecutar JavaScript fuera del navegador.\",\n          \"en\": \"Environment that allows JavaScript to run outside the browser.\"\n        }\n      },\n      {\n        \"term\": \"analogía\",\n        \"definition\": {\n          \"es\": \"Comparación entre dos cosas distintas que tienen algo en común, usada para explicar ideas complejas.\",\n          \"en\": \"A comparison between two different things that share similarities, used to explain complex ideas.\"\n        }\n      },\n      {\n        \"term\": \"engine\",\n        \"definition\": {\n          \"es\": \"Motor o parte principal que ejecuta acciones en un sistema o aplicación.\",\n          \"en\": \"The main part that drives operations in a system or application, like a \'motor\' for software.\"\n        }\n      }\n    ],\n    \"imageUrl\": \"\",\n    \"backgroundColor\": \"#FFF3E0\",\n    \"audioUrl\": \"\",\n    \"avatar\": {\n      \"name\": \"Lina\",\n      \"imageUrl\": \"\",\n      \"position\": \"bottomLeft\"\n    }\n  }" },// code snippet
                                        new LessonContentDTO { Id = 10003, LessonId = 1001, TypeId = 2 ,Order = 3, Content = " {\n        \"title\": {\n            \"en\": \"Installing Angular\",\n            \"es\": \"Instalación de Angular\"\n        },\n        \"textContents\": {\n            \"introduction\": {\n                \"en\": \"Now we are going to install Angular.\",\n                \"es\": \"Ahora podemos a instalar Angular\"\n            },\n            \"contents\": [\n                {\n                    \"en\": \"Open your system terminal and **run** the following command:\",\n                    \"es\": \"Abrimos la terminal de nuestro sistema. Y ejecutamos el siguiente comando\"\n                },\n                {\n                    \"en\": \"npm install -g @angular/cli\",\n                    \"es\": \"npm install -g @angular/cli\"\n                },\n                {\n                    \"en\": \"Based on the previous analogy, we can explain the command like this:\",\n                    \"es\": \"Según la analogía pasada, podemos explicar el comando mostrado así:\"\n                },\n                {\n                    \"en\": \"With Node already installed (the engine), we use npm (the store) to globally install -g Angular CLI (a tool used with JavaScript).\",\n                    \"es\": \"Con Node ya instalado (el motor), usa npm (la tienda) para instalar de forma global -g Angular CLI (una herramienta que se usa con JavaScript).\"\n                }\n            ],\n            \"exercise\": [\n                {\n                    \"type\": \"options\",\n                    \"completed\": false,\n                    \"instruction\": {\n                        \"en\": \"Install Angular using npm. Choose the correct command:\",\n                        \"es\": \"Instalemos Angular con npm. Elige el comando correcto:\"\n                    },\n                    \"options\": [\n                        {\n                            \"text\": \"npm install @angular/cli\",\n                            \"correct\": false,\n                            \"output\": \"Error: Missing global flag `-g`. The Angular CLI won\'t be available as a global command.\"\n                        },\n                        {\n                            \"text\": \"npm install -g @angular/cli\",\n                            \"correct\": true,\n                            \"output\": \"added 267 packages in 12s\\n\\nchanged 1 package, and audited 267 packages in 5s\\n\\nfound 0 vulnerabilities\\n\\nC:\\\\Users\\\\user\\\\AppData\\\\Roaming\\\\npm\\\\ng -> C:\\\\Users\\\\user\\\\AppData\\\\Roaming\\\\npm\\\\node_modules\\\\@angular\\\\cli\\\\bin\\\\ng\\n\\n+ @angular/cli@18.0.3\"\n                        },\n                        {\n                            \"text\": \"ng install angular\",\n                            \"correct\": false,\n                            \"output\": \"Error: Unknown command \'install\'. Did you mean \'ng add\' or \'npm install\'?\"\n                        },\n                        {\n                            \"text\": \"node install angular-cli\",\n                            \"correct\": false,\n                            \"output\": \"Error: \'install\' is not a recognized Node.js command. Use npm to install packages.\"\n                        }\n                    ]\n                }\n            ]\n        },\n        \"vocabulary\": [\n            {\n                \"term\": \"run\",\n                \"definition\": {\n                    \"es\": \"Ejecutar un comando, script o aplicación. En desarrollo web, se usa para iniciar servidores, procesos o herramientas.\",\n                    \"en\": \"To execute a command, script, or application. In web development, it\'s used to start servers, processes, or tools.\"\n                }\n            }\n        ],\n        \"imageUrl\": \"https://your-cdn.com/angular-errors.png\",\n        \"backgroundColor\": \"#FFF3E0\",\n        \"avatar\": {\n            \"name\": \"Lina\",\n            \"imageUrl\": \"\",\n            \"position\": \"bottomLeft\"\n        }\n    }" },
                                        new LessonContentDTO { Id = 10003, LessonId = 1001, TypeId = 2 ,Order = 3, Content = "{\n        \"title\": {\n            \"en\": \"Verify Angular Version \",\n            \"es\": \"Verificar versión de Angular\"\n        },\n        \"textContents\": {\n            \"introduction\": {\n                \"en\": \" \",\n                \"es\": \"Para comprobar la instalación correcta de angular vamos a verificar la versión\"\n            },\n            \"ending\": [\n                {\n                    \"en\": \" \",\n                    \"es\": \"¡ Felicidades, Hemos instalado correctamente Angular ! \"\n                },\n                {\n                    \"en\": \" \",\n                    \"es\": \"Recuerda que para la creación de un proyecto en angular vamos a utilizar el comando ng new nombre-de-proyecto\"\n                }\n            ],\n            \"exercise\": [\n                {\n                    \"type\": \"input\",\n                    \"instruction\": {\n                        \"en\": \"Let\'s verify the version of the Angular CLI. Type the correct command:\",\n                        \"es\": \"Vamos a verificar la versión de nuestro cliente de Angular. Escribe el comando correcto:\"\n                    },\n                    \"input\": \"ng version\",\n                    \"output\": \"     _                      _                 ____ _     ___\\n    / \\\\   _ __   __ _ _   _| | __ _ _ __     / ___| |   |_ _|\\n   / △ \\\\ | \'_ \\\\ / _` | | | | |/ _` | \'__|   | |   | |    | |\\n  / ___ \\\\| | | | (_| | |_| | | (_| | |      | |___| |___ | |\\n /_/   \\\\_\\\\_| |_|\\\\__, |\\\\__,_|_|\\\\__,_|_|       \\\\____|_____|___|\\n                |___/\\n\\nAngular CLI: 18.0.3\\nNode: 22.17.0\\nPackage Manager: npm 10.9.2\\nOS: win32 x64\\n\\nAngular: undefined\\n...\\n\\nPackage                      Version\\n------------------------------------------------------\\n@angular-devkit/architect    0.1800.3 (cli-only)\\n@angular-devkit/core         18.0.3 (cli-only)\\n@angular-devkit/schematics   18.0.3 (cli-only)\\n@schematics/angular          18.0.3 (cli-only)\",\n                    \"eoutput\": \"Incorrect command.\",\n                    \"completed\": false\n                }\n            ]\n        },\n        \"imageUrl\": \"link\",\n        \"backgroundColor\": \"#FFF3E0\",\n        \"avatar\": {\n            \"name\": \"Lina\",\n            \"imageUrl\": \"\",\n            \"position\": \"bottomLeft\"\n        }\n    } " }
                                    ]
                                },
                                new LessonDTO
                                {
                                    Id = 1002,
                                    Title = "CSS errors",
                                    Description = "CSS",
                                    Order = 2,
                                    StageId = 1,
                                    LessonContents =
                                    [
                                        new LessonContentDTO { Id = 10004, LessonId = 1002, TypeId = 1 , Order = 1, Content = "Content 1" },
                                        new LessonContentDTO { Id = 10005, LessonId = 1002, TypeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 10006, LessonId = 1002,     TypeId = 3, Order = 3, Content = "Content 3" },
                                    ]
                                },
                                new LessonDTO
                                {
                                    Id = 1003,
                                    Title = "HTML errors",
                                    Description = "HTML",
                                    Order = 3,
                                    StageId = 1,
                                    LessonContents          =
                                    [
                                        new LessonContentDTO { Id = 10007, LessonId = 1003, TypeId = 1, Order = 1, Content = "Content 1" },
                                        new LessonContentDTO { Id = 10008, LessonId = 1003, TypeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 10009, LessonId = 1003, TypeId = 3, Order = 3, Content = "Content 3" },
                                    ]
                                }
                            }
                        },
                        new CourseDTO
                        {
                            Id = 102,
                            Title = "Connect to API REST",
                            Description = "Learn how to connect",
                            StageId = 1,
                            ThemeId = 1,
                            Lessons = new List<LessonDTO>
                            {
                                new LessonDTO
                                {
                                    Id = 1004,
                                    Title = "HttpClient",
                                    Description = "How to use HttpClient",
                                    Order = 1,
                                    StageId = 1,
                                    LessonContents =
                                    [
                                        new LessonContentDTO { Id = 10010, LessonId = 1004, TypeId = 1, Order = 1, Content = "Content 1" },
                                        new LessonContentDTO { Id = 10011, LessonId = 1004, TypeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 10012, LessonId = 1004, TypeId = 3, Order = 3, Content = "Content 3" },
                                    ]
                                }
                            }
                        }
                    }
                },

                new ThemeDTO
                {
                    Id = 2,
                    Title = "Git & Working in Teams",
                    Description = "Learn git commands and teamwork",
                    Courses = new List<CourseDTO>
                    {
                        new CourseDTO
                        {
                            Id = 201,
                            Title = "Making a Commit",
                            Description = "Manage your commits",
                            StageId = 1,
                            ThemeId = 2,
                            Lessons = new List<LessonDTO>
                            {
                                new LessonDTO
                                {
                                    Id = 2001,
                                    Title = "Stage changes",
                                    Description = "How to stage",
                                    Order = 1,
                                    StageId = 1,
                                    LessonContents = new List<LessonContentDTO>
                                    {
                                        new LessonContentDTO { Id = 20001, LessonId = 2001, TypeId = 1, Order = 1, Content = "Content 1" },
                                        new LessonContentDTO { Id = 20002, LessonId = 2001, TypeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 20003, LessonId = 2001, TypeId = 3, Order = 3, Content = "Content 3" },
                                    }
                                },
                                new LessonDTO
                                {
                                    Id = 2002,
                                    Title = "Push",
                                    Description = "How to push changes",
                                    Order = 2,
                                    StageId = 1,
                                    LessonContents = new List<LessonContentDTO>
                                    {
                                        new LessonContentDTO { Id = 20004, LessonId = 2002, TypeId = 1, Order = 1,Content = "Content 1" },
                                        new LessonContentDTO { Id = 20005, LessonId = 2002, TypeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 20006, LessonId = 2002, TypeId = 3, Order = 3, Content = "Content 3" },
                                    }
                                },
                                new LessonDTO
                                {
                                    Id = 2003,
                                    Title = "Pull",
                                    Description = "How to pull changes",
                                    Order = 3,
                                    StageId = 1,
                                    LessonContents = new List<LessonContentDTO>
                                    {
                                        new LessonContentDTO { Id = 20007, LessonId = 2003, TypeId = 1, Order = 1, Content = "Content 1" },
                                        new LessonContentDTO { Id = 20008, LessonId = 2003, TypeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 20009, LessonId = 2003, TypeId = 3, Order = 3, Content = "Content 3" },
                                    }
                                }
                            }
                        }
                    }
                }
            };

            cache.SetData(themes);
        }
    }
}
