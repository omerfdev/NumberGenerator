using System;

namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:r}", DateTime.Now);
            Console.WriteLine("WELCOME");
            char Mainpage = '0';
            OMERFDEV:
            Console.WriteLine("Number Generator");
            Random x = new Random();
            int number = x.Next(1, 1000000);
            Console.WriteLine("Number is {0}", number);            
            MENU:
            Console.WriteLine("1-New Number Request");
            Console.WriteLine("2-Exit");
            Console.WriteLine("Choose number (1 2)");
            Mainpage = Convert.ToChar(Console.ReadLine());
            
            
            if (Mainpage=='1')
            {
                Console.Clear();
                goto OMERFDEV;
            }
            else if (Mainpage=='2')
            {
                Console.Clear();
                Environment.Exit(0);

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong Command!");
                goto MENU;
            }

        }
    }
}
