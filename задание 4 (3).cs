using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    abstract class Shape
    {
        public abstract string Draw();
    }

    class Circle : Shape
    {
        public override string Draw() => "Рисую круг";
    }

    class Triangle : Shape
    {
        public override string Draw() => "Рисую треугольник";
            
      static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(), new Triangle() };
            foreach (var s in shapes) Console.WriteLine(s.Draw());
        }
    }
}