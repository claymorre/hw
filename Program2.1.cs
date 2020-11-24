using System;

namespace Zadanit_2._1
{
    struct Types_of
    {
        public int number;
        public string type;
        public decimal balance;
        public void DisplayInfo()
        {
            Console.WriteLine($"Номер счета: {number}\nВид счета: {type}\nБаланс: {balance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Types_of User;
            User.number = 81479127;
            User.type = "Credit";
            User.balance = 199857.5M;
            User.DisplayInfo();


         

        }
    }
}
