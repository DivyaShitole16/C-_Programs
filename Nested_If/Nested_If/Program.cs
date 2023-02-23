using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nested_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            if (i == 20)
            {
                if (i > 60)
                {
                    Console.WriteLine("i is smaller than 10");
                }
                else
                {
                    Console.WriteLine("i is greater than 50");
                }
            }
            Console.ReadKey();
        

        }
    }
}
