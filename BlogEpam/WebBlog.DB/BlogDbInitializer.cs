using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebBlog.Models.Entity;
using WebBlog.Models.Entity.QuestionnaireComponents;

namespace WebBlog.DB
{
    class BlogDbInitializer : DropCreateDatabaseAlways<MyDbContext>
    {

      


        protected override void Seed(MyDbContext context)
        {
            #region Create Users
            var user1 = new User { Id = Guid.NewGuid(), Name = "Vlad", Email = "qweera@gmail.com" };
            var user2 = new User { Id = Guid.NewGuid(), Name = "Sergey", Email = "qweete3ra@gmail.com" };
            var user3 = new User { Id = Guid.NewGuid(), Name = "Vadim", Email = "opeete3ra@gmail.com" };
            var user4 = new User { Id = Guid.NewGuid(), Name = "Oleg", Email = "loliolop2@gmail.com" };
            var user5 = new User { Id = Guid.NewGuid(), Name = "Anna", Email = "Annap2@gmail.com" };
            var user6 = new User { Id = Guid.NewGuid(), Name = "Silver", Email = "Silvarop2@gmail.com" };
            var user7 = new User { Id = Guid.NewGuid(), Name = "Max", Email = "loMaxop2@gmail.com" };
            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);
            context.Users.Add(user4);
            context.Users.Add(user5);
            context.Users.Add(user6);
            context.Users.Add(user7);
            #endregion

            #region CreateTags
            var tag1 = new Tag { Signature = "C#" };
            var tag2 = new Tag { Signature = "program" };
            var tag3 = new Tag { Signature = "smart" };
            var tag4 = new Tag { Signature = "C++" };
            var tag5 = new Tag { Signature = "java" };
            var tag6 = new Tag { Signature = "top" };
            var tag7 = new Tag { Signature = "hard" };
            var tag8 = new Tag { Signature = "cool" };
            var tag9 = new Tag { Signature = "midle" };
            var tag10 = new Tag { Signature = "forProgrammer" };
            context.Tags.Add(tag1);
            context.Tags.Add(tag2);
            context.Tags.Add(tag3);
            context.Tags.Add(tag4);
            context.Tags.Add(tag5);
            context.Tags.Add(tag6);
            context.Tags.Add(tag7);
            context.Tags.Add(tag8);
            context.Tags.Add(tag9);
            context.Tags.Add(tag10);
            #endregion

            #region Create Articles
            var articles = new List<Article>
                {
                    new Article
                    {
                        Id = Guid.NewGuid(),
                        Title = "Архитектура веба: основы для начинающих разработчиков",
                        Date = DateTime.Now,
                        Text = "Сюжет рассказывает о бывшем элитном пилоте глубоководных аппаратов ВМФ США, а ныне дайвере-спасателе Джонасе Тэйлоре (Джейсон Стэйтэм), к которому обращается китайский океанограф с просьбой прийти на помощь оказавшимся в ловушке учёным. Дело в том, что подводно-исследовательская экспедиция подверглась атаке гигантской доисторической акулы ‒ Мегалодона, которая считалась вымершей много сотен лет назад. Теперь Тэйлору, вопреки уговорам его дочери Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой.",
                        UserId  =  user1.Id,
                        Tags = new List<Tag>{tag1,tag2,tag3 }
                    },
                    new Article
                    {
                        Id = Guid.NewGuid(),
                        Title = "Архитектура веба: основы для начинающих разработчиков",
                        Date = DateTime.Now,
                        Text = "Сюжет рассказывает о бывшем элитном пилоте глубоководных аппаратов ВМФ США, а ныне дайвере-спасателе Джонасе Тэйлоре (Джейсон Стэйтэм), к которому обращается китайский океанограф с просьбой прийти на помощь оказавшимся в ловушке учёным. Дело в том, что подводно-исследовательская экспедиция подверглась атаке гигантской доисторической акулы ‒ Мегалодона, которая считалась вымершей много сотен лет назад. Теперь Тэйлору, вопреки уговорам его дочери Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой.",
                        UserId  =  user2.Id,
                        Tags = new List<Tag>{tag4,tag5,tag6 }
                    },
                     new Article
                    {
                        Id = Guid.NewGuid(),
                        Title = "Архитектура веба: основы для начинающих разработчиков",
                        Date = DateTime.Now,
                        Text = "Сюжет рассказывает о бывшем элитном пилоте глубоководных аппаратов ВМФ США, а ныне дайвере-спасателе Джонасе Тэйлоре (Джейсон Стэйтэм), к которому обращается китайский океанограф с просьбой прийти на помощь оказавшимся в ловушке учёным. Дело в том, что подводно-исследовательская экспедиция подверглась атаке гигантской доисторической акулы ‒ Мегалодона, которая считалась вымершей много сотен лет назад. Теперь Тэйлору, вопреки уговорам его дочери Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой.",
                        UserId  =  user3.Id,
                        Tags = new List<Tag>{tag7,tag8,tag9 }
                    },
                     new Article
                    {
                        Id = Guid.NewGuid(),
                        Title = "Архитектура веба: основы для начинающих разработчиков",
                        Date = DateTime.Now,
                        Text = "Сюжет рассказывает о бывшем элитном пилоте глубоководных аппаратов ВМФ США, а ныне дайвере-спасателе Джонасе Тэйлоре (Джейсон Стэйтэм), к которому обращается китайский океанограф с просьбой прийти на помощь оказавшимся в ловушке учёным. Дело в том, что подводно-исследовательская экспедиция подверглась атаке гигантской доисторической акулы ‒ Мегалодона, которая считалась вымершей много сотен лет назад. Теперь Тэйлору, вопреки уговорам его дочери Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой.",
                        UserId  =  user4.Id,
                        Tags = new List<Tag>{tag10,tag1 }
                    },
                     new Article
                    {
                        Id = Guid.NewGuid(),
                        Title = "Архитектура веба: основы для начинающих разработчиков",
                        Date = DateTime.Now,
                        Text = "Сюжет рассказывает о бывшем элитном пилоте глубоководных аппаратов ВМФ США, а ныне дайвере-спасателе Джонасе Тэйлоре (Джейсон Стэйтэм), к которому обращается китайский океанограф с просьбой прийти на помощь оказавшимся в ловушке учёным. Дело в том, что подводно-исследовательская экспедиция подверглась атаке гигантской доисторической акулы ‒ Мегалодона, которая считалась вымершей много сотен лет назад. Теперь Тэйлору, вопреки уговорам его дочери Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой.",
                        UserId  =  user5.Id,
                        Tags = new List<Tag>{tag1,tag3 }
                    },
                      new Article
                    {
                        Id = Guid.NewGuid(),
                        Title = "Архитектура веба: основы для начинающих разработчиков",
                        Date = DateTime.Now,
                        Text = "Сюжет рассказывает о бывшем элитном пилоте глубоководных аппаратов ВМФ США, а ныне дайвере-спасателе Джонасе Тэйлоре (Джейсон Стэйтэм), к которому обращается китайский океанограф с просьбой прийти на помощь оказавшимся в ловушке учёным. Дело в том, что подводно-исследовательская экспедиция подверглась атаке гигантской доисторической акулы ‒ Мегалодона, которая считалась вымершей много сотен лет назад. Теперь Тэйлору, вопреки уговорам его дочери Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой.",
                        UserId  =  user6.Id
                    },
                       new Article
                    {
                        Id = Guid.NewGuid(),
                        Title = "Архитектура веба: основы для начинающих разработчиков",
                        Date = DateTime.Now,
                        Text = "Сюжет рассказывает о бывшем элитном пилоте глубоководных аппаратов ВМФ США, а ныне дайвере-спасателе Джонасе Тэйлоре (Джейсон Стэйтэм), к которому обращается китайский океанограф с просьбой прийти на помощь оказавшимся в ловушке учёным. Дело в том, что подводно-исследовательская экспедиция подверглась атаке гигантской доисторической акулы ‒ Мегалодона, которая считалась вымершей много сотен лет назад. Теперь Тэйлору, вопреки уговорам его дочери Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой.",
                        UserId  =  user7.Id,
                        Tags = new List<Tag>{tag1,tag2,tag5 }
                    }
                };
            #endregion

            #region Create Comments
            var comments = new List<Comment>
            {
                new Comment
                    {
                         Id = Guid.NewGuid(),
                         Users =  user1,
                         Type = "GuestPage",
                         Date = DateTime.Now,
                         Text = "Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой."
                    },
                     new Comment
                    {
                         Id = Guid.NewGuid(),
                         Users =  user2,
                         Type = "GuestPage",
                         Date = DateTime.Now,
                         Text = "Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой."
                    },
                      new Comment
                    {
                          Id = Guid.NewGuid(),
                         Users =  user3,
                         Type = "GuestPage",
                         Date = DateTime.Now,
                         Text = "Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой."
                    },
                       new Comment
                    {
                         Users =  user4,
                         Type = "GuestPage",
                         Date = DateTime.Now,
                         Text = "Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой."
                    },
                        new Comment
                    {
                         Id = Guid.NewGuid(),
                         Users = user5,
                         Type = "GuestPage",
                         Date = DateTime.Now,
                         Text = "Суйин, придётся спасти застрявших на глубине Тихого океана учёных и встретиться лицом к лицу с величайшим из хищников всех времён, превозмогая собственный страх и рискуя жизнью. Но мало кто знает, что прежде Джонас уже сталкивался с ужасной 75-метровой акулой."
                    }
            };
            #endregion


            #region Create Questionnaire
            var questionnaire = new Questionnaire
            {
                Id = Guid.NewGuid(),
                Title = "Оцените пожалуйста наш сайт",
                

                Questions = new List<Question>
                {
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Type = "checkbox",
                        Title = "Откуда вы узнали про наш веб - сайт?",
                        Answer = new List<Answer>
                        {
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "От друзей",
                                Cost = 2
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Рекомендовали на работе",
                                Cost = 2
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Увидел рекламу на других сайтах",
                                Cost = 2
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Увидел рекламу на youtube",
                                Cost = 2
                            }
                        }
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Насколько сложно ориентироваться на нашем веб-сайте?",
                        Type = "radiobutton",
                        Answer = new List<Answer>
                        {
                             new Answer
                             {
                                 Id = Guid.NewGuid(),
                                 Title = "Очень просто ",
                                 Cost = 4
                             },
                             new Answer
                             {
                                 Id = Guid.NewGuid(),
                                 Title = "Скорее просто",
                                 Cost = 3
                             },
                             new Answer
                             {
                                 Id = Guid.NewGuid(),
                                 Title = "Нормально",
                                 Cost = 2
                             },
                             new Answer
                             {
                                 Id = Guid.NewGuid(),
                                 Title = "Скорее сложно",
                                 Cost = 1
                             },
                             new Answer
                             {
                                 Id = Guid.NewGuid(),
                                 Title = "Очень сложно",
                                 Cost = 0
                             }
                        }
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Как Вы оцениваете внешний вид нашего веб-сайта?",
                        Type = "radiobutton",
                        Answer = new List<Answer>
                        {
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Очень хороший ",
                                Cost = 4
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Хороший",
                                Cost = 3
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Нормальный",
                                Cost = 2
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Плохой",
                                Cost = 1
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Мне он совсем не нравится",
                                Cost = 0
                            }
                        }
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Как Вы оцениваете актуальность содержания на нашем веб-сайте?",
                        Type = "radiobutton",
                        Answer = new List<Answer>
                        {
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Актуальное ",
                                Cost = 4
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Скорее актуальное",
                                Cost = 3
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Не слишком актуальное",
                                Cost = 1
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Совсем не актуальное",
                                Cost = 0
                            }
                        }
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Насколько Вы в общем довольны нашим веб-сайтом?",
                        Type = "radiobutton",
                        Answer = new List<Answer>
                        {
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Очень доволен/льна",
                                Cost = 4
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Доволен/льна",
                                Cost = 3
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "В среднем доволен/льна",
                                Cost = 2
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Недоволен/льна",
                                Cost = 1
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Очень недоволен/льна",
                                Cost = 0
                            }
                        }
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Вы бы рекомендовали наш веб-сайт другим людям?",
                        Type = "radiobutton",
                        Answer = new List<Answer>
                        {
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Несомненно да",
                                Cost = 4
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Вероятно да",
                                Cost = 3
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Я не знаю",
                                Cost = 2
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Вероятно нет",
                                Cost = 1
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Несомненно нет",
                                Cost = 0
                            }
                        }
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Почему вы пользуетесь нашим сайтом?",
                        Type = "checkbox",
                        Answer = new List<Answer>
                        {
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Интересные статьи",
                                Cost = 2
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Удобный дизайн",
                                Cost = 2
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Свежая информация",
                                Cost = 2
                            },
                            new Answer
                            {
                                Id = Guid.NewGuid(),
                                Title = "Бесплатный контент",
                                Cost = 2
                            }
                        }
                    }
                }
            };
            #endregion
            context.Articles.AddRange(articles);
            context.Comments.AddRange(comments);
            context.Questionnaires.Add(questionnaire);
            context.SaveChanges();
        }
    }
}