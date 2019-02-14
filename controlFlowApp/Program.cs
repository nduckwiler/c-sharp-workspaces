using System;

namespace ControlFlowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;

            if (age >= 35) 
            {
                Console.WriteLine("You can be president!");
            }
            else if (age >= 21)
            {
                Console.WriteLine("You can drink!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You can wait!");
            }
        }
    }
}
