using System;

namespace multifileApp
{
    public class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes caponata");
        }

    }
}
