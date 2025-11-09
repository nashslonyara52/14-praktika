using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class FileName
    {
        static void Main(string[] args)
        {
        Message[] messages = { new Email(), new SMS(), new Message() };
            foreach (var m in messages) m.Send();

            Console.WriteLine();
    }
        public class Message
        {
            public virtual void Send() => Console.WriteLine("Сообщение отправлено.");
        }

        public class Email : Message
        {
            public override void Send() => Console.WriteLine("Email отправлен!");
        }

        public class SMS : Message
        {
            public override void Send() => Console.WriteLine("SMS отправлено!");
        }

    }
}
