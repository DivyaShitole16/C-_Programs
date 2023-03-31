using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace One_dimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays;
            weekDays = new string[] { "Sunday","Monday","Tuesday","Wednesday",     
          "Thursday", "Friday", "satursday" };
            foreach (string day in weekDays)
                Console.WriteLine(day + " ");
            Console.ReadKey();

        }
    }
}
