using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9.a
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Player[] team = { new Warrior(), new Archer(), new Player() };
            foreach (var p in team) p.Attack();
        }
        class Player
        {
            public virtual void Attack() => Console.WriteLine("Атакую!");
        }

        class Warrior : Player
        {
            public override void Attack() => Console.WriteLine("Рублю мечом!");
        }

        class Archer : Player
        {
            public override void Attack() => Console.WriteLine("Стреляю из лука!");
        }
    }
}