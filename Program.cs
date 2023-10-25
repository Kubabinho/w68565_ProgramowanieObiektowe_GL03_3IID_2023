using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Zad1");
            Console.WriteLine("2 - Zad2");
            Console.WriteLine("4 - Zad4");
            Console.WriteLine("5 - Zad5");
            Console.WriteLine("6 - Zad6");
            Console.WriteLine("podaj ktore chccesz zrobic: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if(userChoice == 1)
            {
                Zad1();
            }
            else if(userChoice == 2)
            {
                Zad2();
            }
            else if(userChoice == 4)
            {
                Zad4();
            }
            else if(userChoice == 5)
            {
                Zad5();
            }

        }
        public static void Zad1()
        {
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp % 2 == 0)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("nieparzysta");
            }
        }
        public static void Zad2()
        {
            int temp = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; temp > i; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Zad4()
        {
            int temp = Convert.ToInt32(Console.ReadLine());
            static long silnia(int temp)
            {
                if (temp == 0)
                {
                    return 1;
                }
                else
                {
                    return temp * silnia(temp - 1);
                }
            }
        }
        public static void Zad5()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 10);
            int i = 0;
            while(true)
            {
                i++;
                Console.WriteLine("zgaduj liczbe");
                int temp = Convert.ToInt32(Console.ReadLine());
                if(temp == rand || i > 5)
                {
                    break;
                }
            }
        }
    }
}
