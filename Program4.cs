using System;


namespace Zadanie_4
{
    class Program
    {
        static void Main()
        {
            #region Ввод
            int checknumber1;
            int checknumber2;
            int checknumber3;

            Console.WriteLine("Введите коэффицент a");
            var a = Console.ReadLine();
            goto Checking1;

        Checking1:
            bool check1 = Int32.TryParse(a, out checknumber1);
            if (!check1)
            {
                Console.WriteLine("Введите коэффицент a");
                a = Console.ReadLine();
                goto Checking1;
            }

            Console.WriteLine("Введите коэффицент b");
            var b = Console.ReadLine();
            goto Checking2;

        Checking2:
            bool check2 = Int32.TryParse(b, out checknumber2);

            if (!check2)
            {
                Console.WriteLine("Введите коэффицент b");
                b = Console.ReadLine();
                goto Checking2;
            }
            Console.WriteLine("Введите коэффицент c");
            var c = Console.ReadLine();
            goto Checking3;

        Checking3:
            bool check3 = Int32.TryParse(c, out checknumber3);

            if (!check3)
            {
                Console.WriteLine("Введите коэффицент c");
                c = Console.ReadLine();
                goto Checking3;
            }

            #endregion
            #region Суть программы
            var a1 = Convert.ToInt32(a);
            var b1 = Convert.ToInt32(a);
            var c1 = Convert.ToInt32(a);


            var d = b1 ^ 2 + 4 * a1 * c1;


            if (d > 0 && a1 != 0)
            {
                var x1 = (-(b1) + Math.Sqrt(d)) / (2 * a1);
                var x2 = (-(b1) - Math.Sqrt(d)) / (2 * a1);
                Console.WriteLine($"Первый корень = {x1}; Второй Корень = {x2}");
            }

            else if (d == 0)
            {
                var x = (-(b1) + Math.Sqrt(d)) / (2 * a1);
                Console.WriteLine($"Корень равен = {x} ");
            }

            else if (d < 0)
            {
                Console.WriteLine("Нет действительных корней");
            }

            else if (a1 == 0)
            {
                Console.WriteLine("Уравнение не квадратное");
            }
            #endregion
        }
    }
}