using System;


namespace Numbers
{
    class Program
    {
        static void Main()
        {

            int checkedNumber1;
            int checkedNumber2;

            var number1 = Console.ReadLine();

            var number2 = Console.ReadLine();
            bool success1 = Int32.TryParse(number1, out checkedNumber1);
            bool success2 = Int32.TryParse(number2, out checkedNumber2);

            if (success1)
            {
                if (success2)
                {
                    var result = Convert.ToInt32(number1) / Convert.ToInt32(number2);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Неверный ввод второго числа");
                }
            }
            else if(success1 == false)
            {
                Console.WriteLine("Неверный ввод первого числа");
            }
        }
    }
}