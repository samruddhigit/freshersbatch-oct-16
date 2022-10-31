using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_of_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<String> my_list = new LinkedList<String>();

           
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");
            my_list.AddLast("Zoya");

            Console.WriteLine("Best students of XYZ university:");

           
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
                Console.ReadKey();
            }
        }
    }
}
    

