using System;

namespace BeginningCode
{
     class ItalianChef : Chef
    {
         public override void MakeChefSpecial()
        {
            Console.WriteLine("The Chef makes Vegan Chicken Parmegian");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Italian Chef makes pasta");
        }
    }
}