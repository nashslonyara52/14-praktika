using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.a
{
    internal class _
    {
        static void Main(string[] args)


        {
            Instrument[] band = { new Guitar(), new Drum(), new Instrument() };
            foreach (var i in band) i.Play();

            Console.WriteLine();
        }
        public class Instrument
        {
            public virtual void Play() => Console.WriteLine("Играет музыка...");
        }

        public class Guitar : Instrument
        {
            public override void Play() => Console.WriteLine("Брень-брень!");
        }

        public class Drum : Instrument
        {
            public override void Play() => Console.WriteLine("Бум-бум!");
        }
    }
}
