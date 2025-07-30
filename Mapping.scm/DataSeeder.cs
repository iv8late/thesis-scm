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
                    Title = "Angularr",
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
                                    LessonContents = new List<LessonContentDTO>
                                    {
                                        new LessonContentDTO { Id = 10001, LessonId = 1001, typeId = 1, Order = 1, Content = "Content 1" }, 
                                        new LessonContentDTO { Id = 10002, LessonId = 1001, typeId = 2, Order = 2, Content = "Content 2" },// code snippet
                                        new LessonContentDTO { Id = 10003, LessonId = 1001, typeId = 3 ,Order = 3, Content = "Content 3" },
                                    }
                                },
                                new LessonDTO
                                {
                                    Id = 1002,
                                    Title = "CSS errors",
                                    Description = "CSS",
                                    Order = 2,
                                    StageId = 1,
                                    LessonContents = new List<LessonContentDTO>
                                    {
                                        new LessonContentDTO { Id = 10004, LessonId = 1002, typeId = 1 , Order = 1, Content = "Content 1" },
                                        new LessonContentDTO { Id = 10005, LessonId = 1002, typeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 10006, LessonId = 1002, typeId = 3, Order = 3, Content = "Content 3" },
                                    }
                                },
                                new LessonDTO
                                {
                                    Id = 1003,
                                    Title = "HTML errors",
                                    Description = "HTML",
                                    Order = 3,
                                    StageId = 1,
                                    LessonContents          = new List<LessonContentDTO>
                                    {
                                        new LessonContentDTO { Id = 10007, LessonId = 1003, typeId = 1, Order = 1, Content = "Content 1" },
                                        new LessonContentDTO { Id = 10008, LessonId = 1003, typeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 10009, LessonId = 1003, typeId = 3, Order = 3, Content = "Content 3" },
                                    }
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
                                    LessonContents = new List<LessonContentDTO>
                                    {
                                        new LessonContentDTO { Id = 10010, LessonId = 1004, typeId = 1, Order = 1, Content = "Content 1" },
                                        new LessonContentDTO { Id = 10011, LessonId = 1004, typeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 10012, LessonId = 1004, typeId = 3, Order = 3, Content = "Content 3" },
                                    }
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
                                        new LessonContentDTO { Id = 20001, LessonId = 2001, typeId = 1, Order = 1, Content = "Content 1" },
                                        new LessonContentDTO { Id = 20002, LessonId = 2001, typeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 20003, LessonId = 2001, typeId = 3, Order = 3, Content = "Content 3" },
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
                                        new LessonContentDTO { Id = 20004, LessonId = 2002, typeId = 1, Order = 1,Content = "Content 1" },
                                        new LessonContentDTO { Id = 20005, LessonId = 2002, typeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 20006, LessonId = 2002, typeId = 3, Order = 3, Content = "Content 3" },
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
                                        new LessonContentDTO { Id = 20007, LessonId = 2003, typeId = 1, Order = 1, Content = "Content 1" },
                                        new LessonContentDTO { Id = 20008, LessonId = 2003, typeId = 2, Order = 2, Content = "Content 2" },
                                        new LessonContentDTO { Id = 20009, LessonId = 2003, typeId = 3, Order = 3, Content = "Content 3" },
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
