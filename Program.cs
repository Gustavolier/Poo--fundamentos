using System;
using Balta.ContentConext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao_objetos"));
            articles.Add(new Article("Artigo sobre C#", "orientacao_objetos COM C#"));
            articles.Add(new Article("Artigo sobre .NET", "O poder do .net"));
            foreach (var item in articles)
            {
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Url);
                Console.WriteLine(item.Id);
                Console.WriteLine("");
            }
            var courses = new List<Course>();
            var coursesOop = new Course("Fundamentos OOP", "Fundamentos oop");
            var coursesCsharp = new Course("Fundamentos C#", "Fundamento C#");

            courses.Add(coursesOop);

            courses.Add(coursesCsharp);
            var careers = new List<Career>();

            var careerDotNet = new Career("Especialista .NET", "Especialisat.net");

            var careerItem = new CareerItem(1, "Comece por aqui", "", coursesOop);

            careers.Add(careerDotNet);
            careerDotNet.Items.Add(careerItem);

            Console.WriteLine("Carreiras");

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in careerDotNet.Items.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
                var PayPalSubscription = new PayPalSubscription();
                var student = new Student();

                student.CreateSubscription(PayPalSubscription);
            }
        }
    }
}
