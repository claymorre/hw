using System;

namespace Zadanie_3
{
    class Program
    {
        static void Main()
        {
            var symb = Convert.ToString(Console.ReadLine());
            if (symb.Length == 1)
            {
                char preresult = symb[0];

                var result = ((char)(preresult + 1)).ToString();

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Введен не один символ");
            }
        }
    }
}
