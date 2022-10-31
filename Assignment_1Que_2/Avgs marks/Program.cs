using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avgs_marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second Number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Third Number:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Four Number:");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Fifth Number:");
            double num5 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.Write("The Average of (1), (2), (3), (4), is (5)", num1, num2, num3, num4, average);
            Console.ReadKey();
        }



    }
}
