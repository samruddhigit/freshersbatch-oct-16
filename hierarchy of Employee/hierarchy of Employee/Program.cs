using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        var root = new Employees()
        {
            Id = 15,
            Name = "President",
            employees = new List<Employees>()
            {
                new Employees() {

                    Id = 23, ManagerId = 15, Name = "Director23",
                    employees = new List<Employees>()
                    {
                        new Employees() {
                            Id = 21, ManagerId = 23, Name = "Manager21",
                            employees = new List<Employees>()
                            {
                                new Employees() { Id = 31, ManagerId=21, Name = "Employee31" },
                                new Employees() { Id = 41, ManagerId=21, Name = "Employee41" },
                                new Employees() { Id = 51, ManagerId=21, Name = "Employee51" }
                            }
                        },

                        new Employees() {
                            Id = 22, ManagerId = 23, Name = "Manager22",
                            employees = new List<Employees>()
                            {
                                new Employees() { Id = 32, ManagerId=22, Name = "Employee32" },
                                new Employees() { Id = 42, ManagerId=22, Name = "Employee42" },
                                new Employees() { Id = 52, ManagerId=22, Name = "Employee52" }
                            }
                        }
                    }
                },

                new Employees() {

                    Id = 25, ManagerId = 15, Name = "Director25",
                    employees = new List<Employees>()
                    {
                        new Employees() {
                            Id = 51, ManagerId = 25, Name = "Manager51",
                            employees = new List<Employees>()
                            {
                                new Employees() { Id = 61, ManagerId=51, Name = "Employee61" },
                                new Employees() { Id = 71, ManagerId=51, Name = "Employee71" },
                                new Employees() { Id = 81, ManagerId=51, Name = "Employee81" }
                            }
                        },

                        new Employees() {
                            Id = 62, ManagerId = 25, Name = "Manager62",
                            employees = new List<Employees>()
                            {
                                new Employees() { Id = 72, ManagerId=62, Name = "Employee72" },
                                new Employees() { Id = 82, ManagerId=62, Name = "Employee82" }
                            }
                        }
                    }
                }

            }
        };

        Console.ReadLine();
    }
}

