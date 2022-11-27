using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssignementofEmployee
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }
        public string DOB { get; set; }

        public string DOJ { get; set; }

        public string City { get; set; }

        public Employee(int EmployeeId, string FirstName, string LastName, string Title, string DOB, string DOJ, string City)


        {
            this.EmployeeId = EmployeeId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
            this.DOB = DOB;
            this.DOJ = DOJ;
            this.City = City;
        }
        public override string ToString()
        {
            return EmployeeId + "   " + FirstName + "   " + LastName + "   " + Title + "   " + DOB + "   " + DOJ + "   " + "   " + City;
        }


    }
    internal class Program
    {
        static void Main()
        {//new DateTime(2015, 12, 20);
            List<Employee> list = new List<Employee>
            {
                new Employee(1001,"Malcolm","Daruwalla","Manager","1984/11/16","2011/06/08","Mumbai"),

                new Employee(1002,"Asdin"  ,"Dahlla"   ,"AsstManager","1984/08/20","2012/07/07","Mumbai"),

                new Employee(1003,"Madahvi",  "Oza"    ,"Consultant","1987/11/14","2015/04/2015","Pune"),

                new Employee(1004,"Saba"   ,   "Saikh" ,"SE","1990/11/14","2015/04/12","Pune"),

                new Employee(1005,"Nazia"  ,   "Shaikh","SE","1991/03/08","2016/02/02","Mumbai"),

                new Employee(1006,"Amit"   ,  "Pathak" ,"Consultant", "1998/11/07","2014/08/08","Chennai"),

                new Employee(1007,"Vijay"  , "Natrajan","Consultant","1998/12/02","2015/06/01","Mumbai"),

                new Employee(1008,"Rahul" ,   "Dubey" ,"Associate","1993/11/11","2014/11/06","Chennai"),

                new Employee(1009,"Suresh",  "Mistry" ,"Associate","1992/08/12","2014/13/03","Chennai"),

                new Employee(1010,"Sumit" ,"Shah"     ,"Manager","1991/04/12","2016/01/02","Pune")


          };
            Console.WriteLine("a. Display details of all Employees. ");
            IEnumerable<Employee> result = from x in list select x;

            foreach (Employee e in result)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("====================");

            Console.WriteLine("b. Display details of all Employee whose location is not Mumbai.");
            var query2 = from x2 in list where x2.City != "Mumbai" select x2;
            foreach (Employee e1 in query2)
            {
                Console.WriteLine(e1);
            }
            Console.WriteLine("====================");
            Console.WriteLine("c. Display details of all Employee whose Tittle is AsstManager ");
            var query3 = from x3 in list where x3.Title.Equals("AsstManager") select x3;
            foreach (Employee e2 in query3)
            {
                Console.WriteLine(e2);
            }
            Console.WriteLine("====================");
            Console.WriteLine("d.Display details of all Employee whose LastName Start ith S");
            var query4 = from x4 in list where x4.LastName.StartsWith("S") select x4;
            foreach (Employee e3 in query4)
            {
                Console.WriteLine(e3);
            }
            Console.WriteLine("====================");
            Console.WriteLine("e.Display details of all Employee whose have joined before 1/1/2015");

            Console.WriteLine("\n");

            Console.WriteLine("====================");
            Console.WriteLine("g. Display list of all employee whose designation is Consultant & Associative");
            var query8 = from x7 in list where x7.Title.Contains("Consultant") || x7.Title.Contains("Associate") select x7;
            foreach (Employee e7 in query8)
            {
                Console.WriteLine(e7);
            }
            Console.WriteLine("====================");
            Console.WriteLine("h. Display total number of Employee");

            int No_Of_Employee = list.Count();

            int No_of_Employee2 = (from x in list select x).Count();
            Console.WriteLine(No_Of_Employee);
            Console.WriteLine(No_of_Employee2);
            Console.WriteLine("====================");
            Console.WriteLine("i. Display total number belonging to Chennai ");

            int query9h = list.Where(x1 => x1.City.Equals("Chennai")).Count();
            Console.WriteLine(query9h);
            int query9 = (from xz in list where xz.City.Equals("Chennai") select xz).Count();
            Console.WriteLine(query9);
            Console.WriteLine("====================");
            Console.WriteLine("j. Display Highest Employee Id in List");
            Console.WriteLine(" --Syntax Method--");
            var a = list.Max(x3 => x3.EmployeeId);
            Console.WriteLine(a);

            int query10 = (from xy in list select xy.EmployeeId).Max();
            Console.WriteLine(query10);

            Console.WriteLine("====================");
            Console.WriteLine("k. Display total numbere of Employee joined after 1/1/2015 ");
            Console.WriteLine("...");
            Console.WriteLine("====================");
            Console.WriteLine("l. Display Total Number Of Employee whose designation not Associate");
            int q12 = (from q in list where q.Title != "Associate" select q).Count();
            Console.WriteLine(q12);

            int ql = list.Where(l => l.Title != "Associate").Count();
            Console.WriteLine(ql);

            Console.WriteLine("====================");
            Console.WriteLine("m. Display total number of Employee Based on city.");

            var result1 = from e in list group e by e.City;
            foreach (var v in result1)
            {
                Console.WriteLine("{0}-{1}", v.Key, v.Count());
            }
            Console.WriteLine("====================");
            Console.WriteLine("n. display total number of employee based on city and Tittle");
            var q14 = from c in list
                      group c by new { c.City, c.Title } into t
                      orderby t.Key.City
                      select new { City = t.Key.City, Title = t.Key.Title, TotalCount = t.Count() };
            foreach (var s in q14)
            {
                if (s.TotalCount > 1)
                {

                    Console.WriteLine("Total Number of Employee based On City & Title : {0}-{1}-{2}", s.City, s.Title, s.TotalCount);
                }
            }
            Console.ReadLine();
        }
    }
}
