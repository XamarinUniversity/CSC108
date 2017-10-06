using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Happy Birthday Everyone!");

            var people = Person.GetPeople();

            foreach (Person p in people)
            {
                Console.WriteLine(p.HaveBirthday());
                Console.WriteLine(p.DescribeFamily());
            }
        }
    }
}
