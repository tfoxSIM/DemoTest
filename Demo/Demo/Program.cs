using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageFactory messageFactory = new MessageFactory();
            
            Console.WriteLine(messageFactory.GetGreeting("James"));
            Console.WriteLine(messageFactory.GetGoodbye("Jimmy"));

            Console.ReadLine();
        }
    }
}
