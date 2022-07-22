using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleGeorge
{
`    public class George
    {
        public void StartConversation()
        {
            Console.WriteLine("Hello World");

            var name = "";
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Your name is " + name);

            if (name == "Julia")
            {
                Console.WriteLine("Hello Daughter!");
            }
        }
    }
}