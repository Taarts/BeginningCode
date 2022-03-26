using System;

namespace BeginningCode
{
     class Chef
    {
        public void MakeTofu()
        {
            Console.WriteLine("The Chef makes Tofu");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeChefSpecial()
        {
            Console.WriteLine("The Chef makes Vegan Korean Kimchi Ribs");
        }
    }
}