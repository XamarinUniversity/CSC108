using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static List<string> messages = new List<string>();
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Jesse",
                "Mark",
                null,
                "Stacey"
            };

            //TODO #2: Add try and catch to stop the program crash
            foreach (string name in names)
            {
                SayHello(name);
            }

            //Print all messages
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }
        static void SayHello(string name)
        {
            //TODO #1: use string.IsNullOrEmpty to test the passed
            // parameter - if it's empty or null then throw an exception.
            messages.Add(name);
        }
    }
}
