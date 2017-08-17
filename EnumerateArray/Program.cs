using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();
            MakeDaysPlural(daysOfWeek);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();
            MakeDaysPlural2(daysOfWeek);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < daysOfWeek.Length; i++)
            //{
            //    sb.Append(daysOfWeek[i]);
            //    if (i < daysOfWeek.Length - 2)
            //        sb.Append(", ");
            //    else if (i == daysOfWeek.Length - 2)
            //        sb.Append(" and ");
            //}
            //Console.WriteLine(sb);
        }


        static void MakeDaysPlural(string[] daysOfWeek)
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                string day = daysOfWeek[i];
                daysOfWeek[i] = day + "s";
            }
        }

        /* This will not work because we are merely creating a copy of
         * a reference type and not changing the original variable
        static void MakeDaysPlural2(string[] daysOfWeek)
        {
            foreach (string day in daysOfWeek)
            {
                string day = day + "s";
            }
        }
        */
    }
}
