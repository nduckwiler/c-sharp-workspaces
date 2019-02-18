using System;

namespace multifileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a Chef...");
            Chef joe = new Chef();
            joe.MakeSalad();
            joe.MakeSpecialDish();

            Console.WriteLine("Creating an ItalianChef...");
            ItalianChef giovanni = new ItalianChef();
            giovanni.MakeSalad();
            giovanni.MakePasta();
            giovanni.MakeSpecialDish();
        }
    }
}
