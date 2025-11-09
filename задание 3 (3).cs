using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class FileName
    {
        public class Food
        { 
            static void Main(string[] args)
             
        {
            Food[] lunch = { new Pizza(), new Burger(), new Food() };
            foreach (var f in lunch) f.Eat();

            Console.WriteLine();
        }
            public virtual void Eat() => Console.WriteLine("Едим...");
        }

        public class Pizza : Food
        {
            public override void Eat() => Console.WriteLine("Едим пиццу!");
        }

        public class Burger : Food
        {
            public override void Eat() => Console.WriteLine("Едим бургер!");
        }
    }
}
