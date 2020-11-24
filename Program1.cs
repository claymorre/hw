using System;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя: ");

            var username = Console.ReadLine();

            var greet = "Hello, " + username;

            Console.WriteLine(greet);

            var a = Console.Read();
            Console.WriteLine(a + 1);

        }
    }
}
