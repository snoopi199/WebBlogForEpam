using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models
{
    public class DataContext
    {
        private ICollection<Article> articles;

        public ICollection<Article> Articles
        {
            get { return articles; }
            set { articles = value; }
        }

        private ICollection<Comment> comments;

        public ICollection<Comment> Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        private ICollection<Question> questions;

        public ICollection<Question> Questions
        {
            get { return questions; }
            set { questions = value; }
        }




        public DataContext()
        {
            articles = new List<Article>();
            CreateArticles();
            comments = new List<Comment>();
            CreateComments();
            questions = new List<Question>();
            CreateQuestions();

        }

        private void CreateArticles()
        {
            articles.Add(new Article("Архитектура веба: основы для начинающих разработчиков", DateTime.Now, "Неопытные разработчики вряд ли поймут, что изображено на диаграмме ниже. Но без понимания концептуальных основ работы современного веба тяжело назвать себя хорошим веб-программистом. В материале будет приведено краткоеasfcefvar jgaerhgoi nehoiglfk failwehrl wAERG ANERGJHERLFKJAHK GHKREAMGN KVJLAV NAERKJGHF ARHGIHPRGARMOG LRHNIGFA,JEGMLERAHGAIERRJGMMEARJGIAEOGU,JAERGJMLKJRAHN IOGFHALRIGHAIEHG;IOARG AERHGIAPOG AR GIAR GPA объяснение, которое поможет разобраться в происходящем, а после каждый элемент будет разобран в деталях."));
            articles.Add(new Article("Вредные советы по CSS", DateTime.Now, "Интернет полон различных туториалов и лайфхаков по работе с CSS. Это безусловно здорово, но что, если взглянуть на таблицы стилей с другой стороны? В этой статье вы найдете приёмы, благодаря которым сможете написать по-настоящему ужасный CSS для вашеasfcefvar jgaerhgoi nehoiglfk failwehrl wAERG ANERGJHERLFKJAHK GHKREAMGN KVJLAV NAERKJGHF ARHGIHPRGARMOG LRHNIGFA,JEGMLERAHGAIERRJGMMEARJGIAEOGU,JAERGJMLKJRAHN IOGFHALRIGHAIEHG;IOARG AERHGIAPOG AR GIAR GPAго сайта. И кто знает, может, это пойдёт вам на пользу!"));
            articles.Add(new Article("Подборка инструментов для быстрой разработки приложений на Vue.js", DateTime.Now, "Разрабатывать крутые приложения хорошо, а делать это быстро — еще лучше. В материале подобраны полезные инструменты, которые помогут ускорить разработку на Vue.js, сэкономят время и позволят быстрее закончиasfcefvar jgaerhgoi nehoiglfk failwehrl wAERG ANERGJHERLFKJAHK GHKREAMGN KVJLAV NAERKJGHF ARHGIHPRGARMOG LRHNIGFA,JEGMLERAHGAIERRJGMMEARJGIAEOGU,JAERGJMLKJRAHN IOGFHALRIGHAIEHG;IOARG AERHGIAPOG AR GIAR GPAть проект."));
            articles.Add(new Article("5 способов выровнять HTML-элемент горизонтально и вертикально", DateTime.Now, "Каждый, кто работает с HTML/CSS, рано или поздно сталкивается с проблемой вертикального и горизонтального выравнивания элемента. Чтобы вы лишний раз не гуглили и не находили много разных вариантов, мы собрали зasfcefvar jgaerhgoi nehoiglfk failwehrl wAERG ANERGJHERLFKJAHK GHKREAMGN KVJLAV NAERKJGHF ARHGIHPRGARMOG LRHNIGFA,JEGMLERAHGAIERRJGMMEARJGIAEOGU,JAERGJMLKJRAHN IOGFHALRIGHAIEHG;IOARG AERHGIAPOG AR GIAR GPAдесь несколько самых популярных."));
            articles.Add(new Article("Архитектура веба: основы для начинающих разработчиков", DateTime.Now, "Неопытные разработчики вряд ли поймут, что изображено на диаграмме ниже. Но без понимания концептуальных основ работы современного веба тяжело назвать себя хорошим веб-программистом. В материале будет приведено краткоеasfcefvar jgaerhgoi nehoiglfk failwehrl wAERG ANERGJHERLFKJAHK GHKREAMGN KVJLAV NAERKJGHF ARHGIHPRGARMOG LRHNIGFA,JEGMLERAHGAIERRJGMMEARJGIAEOGU,JAERGJMLKJRAHN IOGFHALRIGHAIEHG;IOARG AERHGIAPOG AR GIAR GPA объяснение, которое поможет разобраться в происходящем, а после каждый элемент будет разобран в деталях."));
            articles.Add(new Article("Вредные советы по CSS", DateTime.Now, "Интернет полон различных туториалов и лайфхаков по работе с CSS. Это безусловно здорово, но что, если взглянуть на таблицы стилей с другой стороны? В этой статье вы найдете приёмы, благодаря которым сможете написать по-настоящему ужасный CSS для вашеasfcefvar jgaerhgoi nehoiglfk failwehrl wAERG ANERGJHERLFKJAHK GHKREAMGN KVJLAV NAERKJGHF ARHGIHPRGARMOG LRHNIGFA,JEGMLERAHGAIERRJGMMEARJGIAEOGU,JAERGJMLKJRAHN IOGFHALRIGHAIEHG;IOARG AERHGIAPOG AR GIAR GPAго сайта. И кто знает, может, это пойдёт вам на пользу!"));
            articles.Add(new Article("Подборка инструментов для быстрой разработки приложений на Vue.js", DateTime.Now, "Разрабатывать крутые приложения хорошо, а делать это быстро — еще лучше. В материале подобраны полезные инструменты, которые помогут ускорить разработку на Vue.js, сэкономят время и позволят быстрее закончиasfcefvar jgaerhgoi nehoiglfk failwehrl wAERG ANERGJHERLFKJAHK GHKREAMGN KVJLAV NAERKJGHF ARHGIHPRGARMOG LRHNIGFA,JEGMLERAHGAIERRJGMMEARJGIAEOGU,JAERGJMLKJRAHN IOGFHALRIGHAIEHG;IOARG AERHGIAPOG AR GIAR GPAть проект."));
            articles.Add(new Article("5 способов выровнять HTML-элемент горизонтально и вертикально", DateTime.Now, "Каждый, кто работает с HTML/CSS, рано или поздно сталкивается с проблемой вертикального и горизонтального выравнивания элемента. Чтобы вы лишний раз не гуглили и не находили много разных вариантов, мы собрали зasfcefvar jgaerhgoi nehoiglfk failwehrl wAERG ANERGJHERLFKJAHK GHKREAMGN KVJLAV NAERKJGHF ARHGIHPRGARMOG LRHNIGFA,JEGMLERAHGAIERRJGMMEARJGIAEOGU,JAERGJMLKJRAHN IOGFHALRIGHAIEHG;IOARG AERHGIAPOG AR GIAR GPAдесь несколько самых популярных."));
            articles.Add(new Article("Адаптивная верстка: что это и как использовать", DateTime.Now, "Адаптивная верстка меняет дизайн страницы в зависимости от поведения пользователя, платформы, размера экрана и ориентации девайса и является неотъемлемой частью современной веб-разработки. Она позволяет существенно экономить asfcefvar jgaerhgoi nehoiglfk failwehrl wAERG ANERGJHERLFKJAHK GHKREAMGN KVJLAV NAERKJGHF ARHGIHPRGARMOG LRHNIGFA,JEGMLERAHGAIERRJGMMEARJGIAEOGU,JAERGJMLKJRAHN IOGFHALRIGHAIEHG;IOARG AERHGIAPOG AR GIAR GPAи не отрисовывать новый дизайн для каждого разрешения, а менять размеры и расположение отдельных элементов."));
        }

        private void CreateComments()
        {
            comments.Add(new Comment("Alex Belov", new DateTime(2018, 09, 05, 20, 11, 11), "Проработал в компании 9 месяцев, могу сказать только хорошее, отличная и дружественная атмосфера, офисная инфраструктруа на высшем уровне (Амосова), для Вас создадут условия комфортной работы и постараются решить волнующий Вас вопрос (техники, отпуска, и тд). В компании есть разные проекты, где есть и сильные специалисты с которыми можно расти параллельно развиваясь, так и проекты, где есть много свободного времени на саморазвитие или же усовершенствование этого же проекта по желанию (а-ля сделай предложение по проекту и реализуй его сам). В общем, мое мнение, что каждый здесь сможет найти себя и реализовать свои амбиции в техническом плане, а при желании развиваться в другом направлении, Вам могут предложить разные варианты развития как в hard-skills, так и в soft-skills плоскостях."));
            comments.Add(new Comment("Lenor", new DateTime(2018, 08, 07, 20, 44, 05), "Знакомство с компанией, если выражаться мягко, прошло совсем неудачно. HR Katarina Kebelesh просто вопиющий непрофессионал своего дела. Было назначено собеседование по Skype, так как на данный момент проживаю в Польше, на должность Java-разработчика. Но увы, никто не явился на собеседование в течении часа! Так же, не было никакого предупреждения об отмене встречи или о переносе собеседования. Просто проигнорировали, тем самым оставив очень неприятное впечатление о фирме и о полной некомпетентности HR’ов."));
            comments.Add(new Comment("Vlad", new DateTime(2017, 04, 09, 20, 54, 01), "Почти год проработал в компании. Все было отлично. После того как проект вышел из Ciklum нам задержали ЗП. Случилось это как раз перед Новым годом. На письма никто со стороны компании не отвечает. Неприятный такой осадочек остался..."));
            comments.Add(new Comment("Valera Sidelnikiv", new DateTime(2018, 01, 09, 20, 54, 01), "Спасибо за работу."));
            comments.Add(new Comment("Sergey Roslov", new DateTime(2017, 12, 05, 20, 11, 11), "Проработал в компании 9 месяцев, могу сказать только хорошее, отличная и дружественная атмосфера, офисная инфраструктруа на высшем уровне (Амосова), для Вас создадут условия комфортной работы и постараются решить волнующий Вас вопрос (техники, отпуска, и тд). В компании есть разные проекты, где есть и сильные специалисты с которыми можно расти параллельно развиваясь, так и проекты, где есть много свободного времени на саморазвитие или же усовершенствование этого же проекта по желанию (а-ля сделай предложение по проекту и реализуй его сам). В общем, мое мнение, что каждый здесь сможет найти себя и реализовать свои амбиции в техническом плане, а при желании развиваться в другом направлении, Вам могут предложить разные варианты развития как в hard-skills, так и в soft-skills плоскостях."));
            comments.Add(new Comment("Andrey", new DateTime(2017, 12, 07, 20, 44, 05), "Знакомство с компанией, если выражаться мягко, прошло совсем неудачно. HR Katarina Kebelesh просто вопиющий непрофессионал своего дела. Было назначено собеседование по Skype, так как на данный момент проживаю в Польше, на должность Java-разработчика. Но увы, никто не явился на собеседование в течении часа! Так же, не было никакого предупреждения об отмене встречи или о переносе собеседования. Просто проигнорировали, тем самым оставив очень неприятное впечатление о фирме и о полной некомпетентности HR’ов."));
            comments.Add(new Comment("Viktor", new DateTime(2017, 12, 09, 20, 54, 01), "Почти год проработал в компании. Все было отлично. После того как проект вышел из Ciklum нам задержали ЗП. Случилось это как раз перед Новым годом. На письма никто со стороны компании не отвечает. Неприятный такой осадочек остался..."));
            comments.Add(new Comment("Sveta", new DateTime(2017, 12, 09, 20, 54, 01), "Спасибо за работу."));
        }

        private void CreateQuestions()
        {
            questions.Add(new Question("Откуда вы узнали про наш веб-сайт?", QustionaryType.checkbox,
                new Answer[]{new Answer("От друзей",3),new Answer("Рекомендовали на работе ",3),
                new Answer("Увидел рекламу на других сайтах",3),new Answer("Увидел рекламу на youtube",3) }));
            questions.Add(new Question("Насколько сложно ориентироваться на нашем веб-сайте?", QustionaryType.radiobutton,
                new Answer[]{new Answer("Очень просто ",4),new Answer("Скорее просто",3),
                new Answer("Нормально",2),new Answer("Скорее сложно",1), new Answer("Очень сложно",0) }));
            questions.Add(new Question("Насколько сложно найти на нашем веб-сайте нужную информацию?", QustionaryType.radiobutton,
                new Answer[]{new Answer("Очень просто ",4),new Answer("Скорее просто",3),
                new Answer("Нормально",2),new Answer("Скорее сложно",1), new Answer("Очень сложно",0) }));
            questions.Add(new Question("Как Вы оцениваете внешний вид нашего веб-сайта?", QustionaryType.radiobutton,
                new Answer[]{new Answer("Очень хороший",4),new Answer("Хороший",3),
                new Answer("Нормальный",2),new Answer("Плохой",1), new Answer("Мне он совсем не нравится",0) }));
            questions.Add(new Question("Как Вы оцениваете актуальность содержания на нашем веб-сайте?", QustionaryType.radiobutton,
                new Answer[]{new Answer("Актуальное",4),
                new Answer("Скорее актуальное",2),new Answer("Не слишком актуальное",1), new Answer("Совсем не актуальное",0) }));
            questions.Add(new Question("Насколько Вы в общем довольны нашим веб-сайтом?", QustionaryType.radiobutton,
               new Answer[]{new Answer("Очень доволен/льна",4),new Answer("Доволен/льна",3),
                new Answer("В среднем доволен/льна",2),new Answer("Недоволен/льна",1), new Answer("Очень недоволен/льна",0) }));
            questions.Add(new Question("Вы бы рекомендовали наш веб-сайт другим людям?", QustionaryType.radiobutton,
              new Answer[]{new Answer("Несомненно да",4),new Answer("Вероятно да",3),
                new Answer("Я не знаю",2),new Answer("Вероятно нет",1), new Answer("Несомненно нет",0) }));
            questions.Add(new Question("Почему вы пользуетесь нашим сайтом?", QustionaryType.checkbox,
               new Answer[]{new Answer("Интересные статьи",3),new Answer("Удобный дизайн ",3),
                new Answer("Свежая информация",3),new Answer("Бесплатный контент",3) }));

        }
    }
}