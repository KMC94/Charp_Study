using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book> {
               new Book { Title = "C# 프로그래밍의 상식", Price = 38000, Pages = 378 },
               new Book { Title = "람다식과 LINQ의 비밀", Price = 25000, Pages = 312 },
               new Book { Title = "원더풀 C# 라이프", Price = 29000, Pages = 385 },
               new Book { Title = "독학 병렬처리 프로그래밍", Price = 48000, Pages = 464 },
               new Book { Title = "구문으로 배우는 C# 입문", Price = 53000, Pages = 604 },
               new Book { Title = "나도 할 수 있는 ASP.NET MVC", Price = 32000, Pages = 453 },
               new Book { Title = "재미있는 C# 프로그래밍 교실", Price = 25400, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("---------");
            Exercise2_2(books);
            Console.WriteLine("---------");
            Exercise2_3(books);
            Console.WriteLine("---------");
            Exercise2_4(books);
            Console.WriteLine("---------");
            Exercise2_5(books);
            Console.WriteLine("---------");
            Exercise2_6(books);
            Console.WriteLine("---------");
            Exercise2_7(books);
            Console.WriteLine("---------");
        }

        static void Exercise2_1(List<Book> books)
        {
            var book = books.FirstOrDefault(b => b.Title == "원더풀 C# 라이프");
            Console.WriteLine("가격 : {0}, 페이지 수 : {1}", book.Price, book.Pages);
        }

        static void Exercise2_2(List<Book> books)
        {
            var count = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine(count);
        }

        static void Exercise2_3(List<Book> books)
        {
            var averagePage = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
            Console.WriteLine(averagePage);
        }

        static void Exercise2_4(List<Book> books)
        {
            var book = books.FirstOrDefault(b => b.Price >= 40000);
            if(book != null)
                Console.WriteLine(book.Title);
        }

        static void Exercise2_5(List<Book> books)
        {
            var maxPage = books.Where(b => b.Price < 40000).Max(b => b.Pages);
            Console.WriteLine(maxPage);
        }

        static void Exercise2_6(List<Book> books)
        {
            var seleted = books.Where(b => b.Pages >= 400)
                .OrderByDescending(b => b.Price);

            foreach (var item in seleted)
            {
                Console.WriteLine("제목:{0} 가격{1}", item.Title, item.Price);
            }
        }

        static void Exercise2_7(List<Book> books)
        {
            var seleted = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500);
            foreach (var item in seleted)
            {
                Console.WriteLine(item.Title);
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
}
