using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Article about OOP", "oriented-objects"));
            articles.Add(new Article("Article about C#", "csharp"));
            articles.Add(new Article("Article about .NET", "dotnet"));

            /*foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }*/

            var courses = new List<Course>();
            var courseOOP = new Course("OOP Fundamentals", "oop-fundamentals");
            var courseCsharp = new Course("C# Fundamentals", "csharp-fundamentals");
            var courseASPNET = new Course("ASP.NET Fundamentals", "aspnet-fundamentals");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseASPNET);


            var careers = new List<Career>();
            var careerDotnet = new Career(".NET Specialist", "specialist-dotnet");
            var careerItem3 = new CareerItem(3, "Learn .NET", "", courseASPNET);
            var careerItem2 = new CareerItem(2, "Learn OOP", "", courseOOP);
            var careerItem = new CareerItem(1, "Start here", "", courseCsharp);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
        }

    }
}
