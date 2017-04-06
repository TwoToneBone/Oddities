using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oddities
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> outputs = new List<string>();
            int loops = int.Parse(Console.ReadLine());
            for (int i = 0; i < loops; i++)
            {
                int input = int.Parse(Console.ReadLine());

                string @out = Math.Abs(input % 2) == 0 ? $"{input} is even" : $"{input} is odd";

                outputs.Add(@out);
            }
            foreach (var s in outputs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
