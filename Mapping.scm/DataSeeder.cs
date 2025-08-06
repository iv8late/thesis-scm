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
                                    Title = "Requirements for Angular",
                                    Description = "Get your workspace ready to build web applications",
                                    Order = 1,
                                    StageId = 1,
                                    LessonContents =
                                    [
                                        new LessonContentDTO { Id = 10001, LessonId = 1001, TypeId = 1, Order = 1, Content = " {\n    \"title\": {\n      \"en\": \"Introduction to Angular\",\n      \"es\": \"Introducción a Angular \"\n    },\n    \"textContents\": {\n      \"concept\": {\n        \"en\": \"Angular is a **framework** for building web applications, based on components.\",\n        \"es\": \"Angular es un **marco de trabajo** para la realización de aplicaciones web, basado en componentes. \"\n      },\n      \"introduction\": [\n        {\n          \"en\": \"Let\'s get familiar with the basic concepts.\",\n          \"es\": \"Vamos a familiarizarnos con los conceptos bases.  \"\n        }\n      ],\n      \"ending\": [\n        {\n          \"en\": \"Before continuing with the Angular installation, Node.js is required. If you don\'t have it installed, follow these steps:\",\n          \"es\": \"Antes de continuar con la instalación de Angular es necesario lo Node.js. Si no lo tienes estos son los pasos para la instalación:\"\n        },\n        {\n          \"en\": \"1. Go to the official website.\",\n          \"es\": \"1. Ir al sitio oficial.\"\n        },\n        {\n          \"en\": \"Visit: nodejs.org\",\n          \"es\": \"Ve a: nodejs.org \"\n        },\n        {\n          \"en\": \"2. Download the installer.\",\n          \"es\": \"2. Descargar el instalador. \"\n        },\n        {\n          \"en\": \"You will see two versions: LTS (Long Term Support), recommended for most users. Choose LTS and download the installer for your operating system.\",\n          \"es\": \"Verás dos versiones: LTS (Long Term Support): recomendada para la mayoría de los usuarios. Elige LTS y descarga el instalador para tu sistema operativo. \"\n        },\n        {\n          \"en\": \"3. Run the installer.\",\n          \"es\": \"3. Ejecutar el instalador. \"\n        },\n        {\n          \"en\": \"Double-click the downloaded file. Accept the terms and conditions. Leave the default options and click Next until the installation is complete.\",\n          \"es\": \"Haz doble clic en el archivo descargado. Acepta los términos y condiciones.Deja las opciones por defecto y haz clic en Next hasta terminar.\"\n        }\n      ],\n      \"contents\": [\n        {\n          \"en\": \"A **component** is a part or element that is part of a larger whole.\",\n          \"es\": \"Un **componente** es una parte o elemento que forma parte de un todo más grande.\"\n        },\n        {\n          \"en\": \"In Angular, a component is made up of 3 types of files\",\n          \"es\": \"En Angular el componente se conforma de 3 elementos/tipos de archivos.\"\n        },\n        {\n          \"en\": \"CSS, HTML, and TS.\",\n          \"es\": \"CSS, HTML, Y TS. \"\n        },\n        {\n          \"en\": \"HTML structures the page of a website\",\n          \"es\": \".html es el archivo que permite estructura el cuerpo de la página web\"\n        },\n        {\n          \"en\": \"CSS is the file that adds styles to the HTML.\",\n          \"es\": \".css es el archivo que le da estilos al .html\"\n        },\n        {\n          \"en\": \"And the TS file contains the logic that gives functionality to the HTML.\",\n          \"es\": \"y el .ts contiene la lógica que permite al html tener funcionalidad.\"\n        }\n      ]\n    },\n    \"imageUrl\": \"link\",\n    \"backgroundColor\": \"#FFF3E0\",\n    \"audioUrl\": \"link\",\n    \"avatar\": {\n      \"name\": \"Lina\",\n      \"imageUrl\": \"link\",\n      \"position\": \"bottomLeft\"\n    },\n    \"vocabulary\": [\n      {\n        \"term\": \"component\",\n        \"definition\": {\n          \"es\": \"Una parte reutilizable de una aplicación Angular que contiene HTML, CSS y lógica (TS).\",\n          \"en\": \"A reusable part of an Angular app containing HTML, CSS, and logic (TS).\"\n        }\n      },\n      {\n        \"term\": \"framework\",\n        \"definition\": {\n          \"es\": \"Una estructura que facilita el desarrollo de software.\",\n          \"en\": \"A structure that helps in building software applications.\"\n        }\n      },\n      {\n        \"term\": \"npm\",\n        \"definition\": {\n          \"es\": \"Gestor de paquetes de Node.js para instalar herramientas.\",\n          \"en\": \"Node.js package manager used to install tools.\"\n        }\n      },\n      {\n        \"term\": \"Node.js\",\n        \"definition\": {\n          \"es\": \"Entorno que permite ejecutar JavaScript fuera del navegador.\",\n          \"en\": \"Environment that allows JavaScript to run outside the browser.\"\n        }\n      }\n    ]\n  }" },
                                        new LessonContentDTO { Id = 10002, LessonId = 1001, TypeId = 1, Order = 2, Content = "{\n    \"title\": {\n      \"en\": \"Node.js and npm \",\n      \"es\": \"Node.js y npm \" \n    },\n    \"textContents\": {\n      \"introduction\":[ {\n        \"en\": \"Before creating a project, we need to get familiar with these concepts.\",\n        \"es\": \"Antes de crear un proyecto. Debemos conocer familiarizarnos con estos conceptos \"\n      }],\n      \"contents\": [\n        {\n          \"en\": \"To install Angular, Node.js is required—it\'s the JavaScript runtime environment.\",\n          \"es\": \"Pues instalar Angular se necesita Node.js, el entorno de ejecución de JavaScript\"\n        },\n        {\n          \"en\": \"Let\'s look at the following analogy.\",\n          \"es\": \"Veamos la siguiente analogía.\"\n        }\n      ]\n      \n    },\n    \"table\": [\n        {\n          \"element\": {\n            \"en\": \"JavaScript\",\n            \"es\": \"JavaScript\"\n          },\n          \"example\": {\n            \"en\": \"🔧 The language used to build the car\",\n            \"es\": \"🔧 El lenguaje para construir carros\"\n          },\n          \"description\": {\n            \"en\": \"The programming language\",\n            \"es\": \"Es el lenguaje de programación\"\n          }\n        },\n        {\n          \"element\": {\n            \"en\": \"Node.js\",\n            \"es\": \"Node.js\"\n          },\n          \"example\": {\n            \"en\": \"🚗 The car engine\",\n            \"es\": \"🚗 El motor del carro\"\n          },\n          \"description\": {\n            \"en\": \"Executes JavaScript outside the browser\",\n            \"es\": \"Ejecuta JavaScript fuera del navegador\"\n          }\n        },\n        {\n          \"element\": {\n            \"en\": \"npm\",\n            \"es\": \"npm\"\n          },\n          \"example\": {\n            \"en\": \"🛒 The parts store\",\n            \"es\": \"🛒 La tienda de repuestos\"\n          },\n          \"description\": {\n            \"en\": \"Installs tools like Angular\",\n            \"es\": \"Instala herramientas como Angular\"\n          }\n        },\n        {\n          \"element\": {\n            \"en\": \"Angular CLI\",\n            \"es\": \"Angular CLI\"\n          },\n          \"example\": {\n            \"en\": \"⚙️ A tool you install to work on the car\",\n            \"es\": \"⚙️ Una herramienta que compras para mejorar el carro\"\n          },\n          \"description\": {\n            \"en\": \"A utility to work with Angular projects\",\n            \"es\": \"Una utilidad para trabajar con proyectos Angular\"\n          }\n        }\n      ],\n    \"vocabulary\": [\n      {\n        \"term\": \"npm\",\n        \"definition\": {\n          \"es\": \"Gestor de paquetes de Node.js para instalar herramientas.\",\n          \"en\": \"Node.js package manager, used to install tools.\"\n        }\n      },\n      {\n        \"term\": \"Node.js\",\n        \"definition\": {\n          \"es\": \"Entorno que permite ejecutar JavaScript fuera del navegador.\",\n          \"en\": \"Environment that allows JavaScript to run outside the browser.\"\n        }\n      },\n      {\n        \"term\": \"analogía\",\n        \"definition\": {\n          \"es\": \"Comparación entre dos cosas distintas que tienen algo en común, usada para explicar ideas complejas.\",\n          \"en\": \"A comparison between two different things that share similarities, used to explain complex ideas.\"\n        }\n      },\n      {\n        \"term\": \"engine\",\n        \"definition\": {\n          \"es\": \"Motor o parte principal que ejecuta acciones en un sistema o aplicación.\",\n          \"en\": \"The main part that drives operations in a system or application, like a \'motor\' for software.\"\n        }\n      }\n    ],\n    \"imageUrl\": \"link\",\n    \"backgroundColor\": \"#FFF3E0\",\n    \"audioUrl\": \"link\",\n    \"avatar\": {\n      \"name\": \"Lina\",\n      \"imageUrl\": \"link\",\n      \"position\": \"bottomLeft\"\n    }\n  }" },// code snippet
                                        new LessonContentDTO { Id = 10003, LessonId = 1001, TypeId = 2 ,Order = 3, Content = "{\n        \"title\": {\n            \"en\": \"Installing Angular\",\n            \"es\": \"Instalación de Angular\"\n        },\n        \"textContents\": {\n            \"introduction\": [\n                {\n                    \"en\": \"Now we are going to install Angular.\",\n                    \"es\": \"Ahora podemos a instalar Angular\"\n                }\n            ],\n            \"contents\": [\n                {\n                    \"en\": \"Open your system terminal and **run** the following command:\",\n                    \"es\": \"Abrimos la terminal de nuestro sistema. Y ejecutamos el siguiente comando\"\n                },\n                {\n                    \"en\": \"npm install -g @angular/cli\",\n                    \"es\": \"npm install -g @angular/cli\"\n                },\n                {\n                    \"en\": \"Based on the previous analogy, we can explain the command like this:\",\n                    \"es\": \"Según la analogía pasada, podemos explicar el comando mostrado así:\"\n                },\n                {\n                    \"en\": \"With Node already installed (the engine), we use npm (the store) to globally install -g Angular CLI (a tool used with JavaScript).\",\n                    \"es\": \"Con Node ya instalado (el motor), usa npm (la tienda) para instalar de forma global -g Angular CLI (una herramienta que se usa con JavaScript).\"\n                }\n            ]\n        },\n        \"exercise\": [\n            {\n                \"type\": \"options\",\n                \"completed\": false,\n                \"instruction\": {\n                    \"en\": \"Install Angular using npm. Choose the correct command:\",\n                    \"es\": \"Instalemos Angular con npm. Elige el comando correcto:\"\n                },\n                \"options\": [\n                    {\n                        \"text\": \"npm install @angular/cli\",\n                        \"correct\": false,\n                        \"output\": \"Error: Missing global flag `-g`. The Angular CLI won\'t be available as a global command.\"\n                    },\n                    {\n                        \"text\": \"npm install -g @angular/cli\",\n                        \"correct\": true,\n                        \"output\": \"added 267 packages in 12s\\n\\nchanged 1 package, and audited 267 packages in 5s\\n\\nfound 0 vulnerabilities\\n\\nC:\\\\Users\\\\user\\\\AppData\\\\Roaming\\\\npm\\\\ng -> C:\\\\Users\\\\user\\\\AppData\\\\Roaming\\\\npm\\\\node_modules\\\\@angular\\\\cli\\\\bin\\\\ng\\n\\n+ @angular/cli@18.0.3\"\n                    },\n                    {\n                        \"text\": \"ng install angular\",\n                        \"correct\": false,\n                        \"output\": \"Error: Unknown command \'install\'. Did you mean \'ng add\' or \'npm install\'?\"\n                    },\n                    {\n                        \"text\": \"node install angular-cli\",\n                        \"correct\": false,\n                        \"output\": \"Error: \'install\' is not a recognized Node.js command. Use npm to install packages.\"\n                    }\n                ]\n            }\n        ],\n        \"vocabulary\": [\n            {\n                \"term\": \"run\",\n                \"definition\": {\n                    \"es\": \"Ejecutar un comando, script o aplicación. En desarrollo web, se usa para iniciar servidores, procesos o herramientas.\",\n                    \"en\": \"To execute a command, script, or application. In web development, it\'s used to start servers, processes, or tools.\"\n                }\n            }\n        ],\n        \"imageUrl\": \"link\",\n        \"backgroundColor\": \"#FFF3E0\",\n        \"avatar\": {\n            \"name\": \"Lina\",\n            \"imageUrl\": \"link\",\n            \"position\": \"bottomLeft\"\n        }\n    }" },
                                        new LessonContentDTO { Id = 10003, LessonId = 1001, TypeId = 2 ,Order = 4, Content = "  {\r\n        \"title\": {\r\n            \"en\": \"Verify Angular Version \",\r\n            \"es\": \"Verificar versión de Angular\"\r\n        },\r\n        \"textContents\": {\r\n            \"introduction\": [\r\n                {\r\n                    \"en\": \" \",\r\n                    \"es\": \"Para comprobar la instalación correcta de angular vamos a verificar la versión\"\r\n                }\r\n            ],\r\n            \"ending\": [\r\n                {\r\n                    \"en\": \" \",\r\n                    \"es\": \"¡ Felicidades, Hemos instalado correctamente Angular ! \"\r\n                },\r\n                {\r\n                    \"en\": \" \",\r\n                    \"es\": \"Recuerda que para la creación de un proyecto en angular vamos a utilizar el comando ng new nombre-de-proyecto\"\r\n                }\r\n            ]\r\n           \r\n        },\r\n         \"exercise\": [\r\n                {\r\n                    \"type\": \"input\",\r\n                    \"instruction\": {\r\n                        \"en\": \"Let's verify the version of the Angular CLI. Type the correct command:\",\r\n                        \"es\": \"Vamos a verificar la versión de nuestro cliente de Angular. Escribe el comando correcto:\"\r\n                    },\r\n                    \"input\": \"ng version\",\r\n                    \"output\": \"    _                      _                 ____ _     ___\\n    / \\\\   _ __   __ _ _   _| | __ _ _ __     / ___| |   |_ _|\\n   / △ \\\\ | '_ \\\\ / _` | | | | |/ _` | '__|   | |   | |    | |\\n  / ___ \\\\| | | | (_| | |_| | | (_| | |      | |___| |___ | |\\n /_/   \\\\_\\\\_| |_|\\\\__, |\\\\__,_|_|\\\\__,_|_|       \\\\____|_____|___|\\n                |___/\\n\\nAngular CLI: 18.0.3\\nNode: 22.17.0\\nPackage Manager: npm 10.9.2\\nOS: win32 x64\\n\\nAngular: undefined\\n...\\n\\nPackage                      Version\\n------------------------------------------------------\\n@angular-devkit/architect    0.1800.3 (cli-only)\\n@angular-devkit/core         18.0.3 (cli-only)\\n@angular-devkit/schematics   18.0.3 (cli-only)\\n@schematics/angular          18.0.3 (cli-only)\",\r\n                    \"eoutput\": \"Incorrect command.\",\r\n                    \"completed\": false\r\n                }\r\n            ],\r\n        \"imageUrl\": \"LINK\",\r\n        \"backgroundColor\": \"#FFF3E0\",\r\n        \"avatar\": {\r\n            \"name\": \"Lina\",\r\n            \"imageUrl\": \"LINK\",\r\n            \"position\": \"bottomLeft\"\r\n        }\r\n    }" }
                                    ]
                                },
                                new LessonDTO
                                {
                                    Id = 1002,
                                    Title = "Let's build a project",
                                    Description = "Build your project and learn ",
                                    Order = 2,
                                    StageId = 1,
                                    LessonContents =
                                    [
                                        new LessonContentDTO { Id = 10004, LessonId = 1002, TypeId = 2 , Order = 1, Content ="{\n  \"title\": {\n    \"en\": \"Introduction to Angular\",\n    \"es\": \"Introducción a Angular\"\n  },\n  \"textContents\": {\n    \"introduction\": [\n      {\n        \"en\": \"Now that we have everything ready, let\'s create a new Angular project using the terminal.\",\n        \"es\": \"Ahora con todo lo necesario vamos a crear un proyecto desde nuestra terminal.\"\n      }\n    ],\n    \"ending\": [\n      {\n        \"en\": \"In the upcoming lessons, we will work with CSS in our Angular project.\",\n        \"es\": \"Para el proyecto de las siguientes lecciones vamos a trabajar con CSS.\"\n      }\n    ],\n    \"exercise\": [\n      {\n        \"type\": \"options\",\n        \"completed\": false,\n        \"instruction\": {\n          \"en\": \"Install Angular using npm. Choose the correct command:\",\n          \"es\": \"Creamos un proyecto. Elige el comando correcto:\"\n        },\n        \"options\": [\n          {\n            \"text\": \"npm create project-name\",\n            \"correct\": false,\n            \"output\": \"Error: Unknown command \'npm create\'.\"\n          },\n          {\n            \"text\": \"ng new project-name\",\n            \"correct\": true,\n            \"output\": \"LINK IMAGEN DE TERMINAL\"\n          },\n          {\n            \"text\": \"ng create project-name\",\n            \"correct\": false,\n            \"output\": \"Error: Unknown command \'ng create\'. Did you mean \'ng add\' ?\"\n          },\n          {\n            \"text\": \"node new project-name\",\n            \"correct\": false,\n            \"output\": \"Error: \'new\' is not a recognized Node.js command.\"\n          }\n        ]\n      }\n    ]\n  },\n  \"imageUrl\": \"link\",\n  \"backgroundColor\": \"#FFF3E0\",\n  \"audioUrl\": \"link\",\n  \"avatar\": {\n    \"name\": \"Lina\",\n    \"imageUrl\": \"link\",\n    \"position\": \"bottomLeft\"\n  }\n}\n" },
                                        new LessonContentDTO { Id = 10005, LessonId = 1002, TypeId = 1, Order = 2, Content = "{\r\n    \"title\": {\r\n      \"en\": \"Project Pre-settings\",\r\n      \"es\": \"Configuración previa del proyecto\"\r\n    },\r\n    \"textContents\": {\r\n      \"introduction\": [\r\n        {\r\n          \"en\": \"When creating a project, the following questions may appear. Let’s take a moment to understand these terms.\",\r\n          \"es\": \"Al momento de crear un proyecto, probablemente han de salir las siguientes preguntas. Vamos a entender un poco los siguientes términos.\"\r\n        }\r\n      ],\r\n      \"ending\": [\r\n        {\r\n          \"en\": \"Now that you know what these terms mean, you'll be able to make better choices when setting up your project.\",\r\n          \"es\": \"Ahora que ya sabes lo que significan estos términos, podrás tomar mejores decisiones al configurar tu proyecto.\"\r\n        }\r\n      ],\r\n      \"contents\": [\r\n        {\r\n          \"en\": \"**Which** stylesheet format would you like to use?\",\r\n          \"es\": \"¿Qué formato de **hoja de estilos** te gustaría usar?\"\r\n        },\r\n        {\r\n          \"en\": \"Stylesheet formats are different ways or languages to write **CSS** in web projects.\",\r\n          \"es\": \"Los formatos de hojas de estilos son diferentes formas o lenguajes para escribir estilos **CSS** en proyectos web.\"\r\n        },\r\n        {\r\n          \"en\": \"Some formats like SCSS or LESS offer extra features that make writing styles easier and more powerful.\",\r\n          \"es\": \"Algunos formatos de hojas de estilos (como SCSS o LESS) tienen herramientas extra que hacen más fácil y potente escribir estilos.\"\r\n        },\r\n        {\r\n          \"en\": \"The next common question you will see is:\",\r\n          \"es\": \"La siguiente pregunta que suele aparecer es:\"\r\n        },\r\n        {\r\n          \"en\": \"This asks if you want to turn on features that generate your web pages on the server or ahead of time for better **performance** and SEO.\",\r\n          \"es\": \"Esta pregunta es para saber si quieres activar funciones que generan las páginas web en el servidor o por adelantado para mejor rendimiento y SEO.\"\r\n        },\r\n        {\r\n          \"en\": \"SEO stands for **Search Engine Optimization**. It is the set of techniques to make your website more visible and easy to find on search engines like Google.\",\r\n          \"es\": \"SEO significa **Search Engine Optimization**. Es el conjunto de técnicas para hacer que tu sitio web sea más visible y fácil de encontrar en buscadores como Google.\"\r\n        },\r\n        {\r\n          \"en\": \"Good SEO helps your site rank higher in search results. To do this, search engines need to easily read the HTML content.\",\r\n          \"es\": \"Un buen SEO ayuda a que tu web aparezca más alto en los resultados de búsqueda. Para esto, los motores de búsqueda necesitan leer el contenido HTML fácilmente.\"\r\n        },\r\n        {\r\n          \"en\": \"Let's see a comparison in the following table:\",\r\n          \"es\": \"Veamos una comparativa en la siguiente tabla:\"\r\n        }\r\n      ]\r\n    },\r\n    \"table\": [\r\n      {\r\n        \"element\": {\r\n          \"en\": \"SSR (Server-Side Rendering)\",\r\n          \"es\": \"SSR (Renderización en el Servidor)\"\r\n        },\r\n        \"example\": {\r\n          \"en\": \"Server builds page on every request.\",\r\n          \"es\": \"El servidor crea la página en cada **petición.**\"\r\n        },\r\n        \"description\": {\r\n          \"en\": \"Use for dynamic content and better SEO.\",\r\n          \"es\": \"Usa para contenido dinámico y mejor SEO.\"\r\n        }\r\n      },\r\n      {\r\n        \"element\": {\r\n          \"en\": \"SSG (Static Site Generation)\",\r\n          \"es\": \"SSG (Generación de Sitios **Estáticos**)\"\r\n        },\r\n        \"example\": {\r\n          \"en\": \"Pages pre-built before deployment.\",\r\n          \"es\": \"Páginas creadas antes del despliegue.\"\r\n        },\r\n        \"description\": {\r\n          \"en\": \"Use for mostly static sites and fast loading.\",\r\n          \"es\": \"Usa para sitios estáticos y carga rápida.\"\r\n        }\r\n      },\r\n      {\r\n        \"element\": {\r\n          \"en\": \"Prerendering\",\r\n          \"es\": \"Prerendering\"\r\n        },\r\n        \"example\": {\r\n          \"en\": \"Pages generated ahead for SEO.\",\r\n          \"es\": \"Páginas generadas por adelantado para SEO.\"\r\n        },\r\n        \"description\": {\r\n          \"en\": \"Use for specific pages needing SEO boost.\",\r\n          \"es\": \"Usa para páginas específicas que necesitan SEO.\"\r\n        }\r\n      }\r\n    ],\r\n    \"vocabulary\": [\r\n      {\r\n        \"term\": \"stylesheet\",\r\n        \"definition\": {\r\n          \"es\": \"Archivo o formato utilizado para definir los estilos visuales (como colores, márgenes y tipografías) de una página web.\",\r\n          \"en\": \"A file or format used to define the visual styles (like colors, margins, and fonts) of a web page.\"\r\n        }\r\n      },\r\n      {\r\n        \"term\": \"CSS\",\r\n        \"definition\": {\r\n          \"es\": \"Lenguaje utilizado para describir la presentación de un documento HTML. Controla el diseño, colores y estilos.\",\r\n          \"en\": \"A language used to describe the presentation of an HTML document. It controls layout, colors, and styles.\"\r\n        }\r\n      },\r\n      {\r\n        \"term\": \"enable\",\r\n        \"definition\": {\r\n          \"es\": \"Activar o permitir una funcionalidad o característica en un sistema.\",\r\n          \"en\": \"To activate or allow a feature or functionality in a system.\"\r\n        }\r\n      },\r\n      {\r\n        \"term\": \"Server-Side Rendering (SSR)\",\r\n        \"definition\": {\r\n          \"es\": \"Técnica en la que el contenido HTML de una página se genera en el servidor antes de enviarlo al navegador.\",\r\n          \"en\": \"A technique where a page's HTML content is generated on the server before being sent to the browser.\"\r\n        }\r\n      },\r\n      {\r\n        \"term\": \"Static Site Generation (SSG)\",\r\n        \"definition\": {\r\n          \"es\": \"Proceso de generar páginas HTML estáticas durante el build, en lugar de generarlas en tiempo real.\",\r\n          \"en\": \"The process of generating static HTML pages at build time instead of on-demand.\"\r\n        }\r\n      },\r\n      {\r\n        \"term\": \"Prerendering\",\r\n        \"definition\": {\r\n          \"es\": \"Técnica que genera páginas web por adelantado, antes de que el usuario las solicite.\",\r\n          \"en\": \"A technique that generates web pages ahead of time, before a user requests them.\"\r\n        }\r\n      },\r\n      {\r\n        \"term\": \"Performance\",\r\n        \"definition\": {\r\n          \"es\": \"Velocidad y eficiencia con la que un sitio web carga y responde.\",\r\n          \"en\": \"The speed and efficiency with which a website loads and responds.\"\r\n        }\r\n      },\r\n      {\r\n        \"term\": \"petición\",\r\n        \"definition\": {\r\n          \"es\": \"Solicitud que hace un cliente (como un navegador) para obtener datos o una página web del servidor.\",\r\n          \"en\": \"A request made by a client (like a browser) to get data or a web page from the server.\"\r\n        }\r\n      },\r\n      {\r\n        \"term\": \"estático\",\r\n        \"definition\": {\r\n          \"es\": \"Contenido que no cambia y se entrega tal cual, sin generarse dinámicamente en cada acceso.\",\r\n          \"en\": \"Content that does not change and is delivered as-is, without being generated dynamically on each access.\"\r\n        }\r\n      }\r\n    ]\r\n  }" },
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
