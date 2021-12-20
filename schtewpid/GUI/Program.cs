using System;
using System.Collections.Generic;

namespace GUI
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Student : Person
    {
        public string Class { get; set; }
    }
    class Teacher : Person
    {
        public string TeachableClass { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> mainList = new List<Person>();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n***STUDENT MANAGEMENT SYSTEM***");
                Console.WriteLine("Enter Your Choice:");
                Console.WriteLine("1 -> Add New Student");
                Console.WriteLine("11 -> Add New Teacher");
                Console.WriteLine("2 -> View All Persons");
                Console.WriteLine("3 -> Exit\n");
                string prompt = Console.ReadLine();
                switch (prompt)
                {
                    case "1":
                        Console.WriteLine("Add new Student (Format: [Name] [Age] [Class]");
                        AddNewStudent(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), mainList);
                        break;
                    case "11":
                        Console.WriteLine("Add new Teacher (Format: [Name] [Age] [Teachable Class]");
                        AddNewTeacher(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), mainList);
                        break;
                    case "2":
                        foreach(Person prs in mainList)
                        {
                            Console.WriteLine("Students:");
                            Console.WriteLine($"Name: {prs.Name}, Age: {prs.Age}");
                        }
                        break;
                    case "3":
                        exit = true;
                        break;
                }
            }

        }
        static void AddNewStudent(string sName, int sAge, string sClass, List<Person> lst)
        {
            Student std = new Student() { Name = sName, Age = sAge, Class = sClass };
            lst.Add(std);
        }
        static void AddNewTeacher(string sName, int sAge, string sClass, List<Person> lst)
        {
            Teacher tch = new Teacher() { Name = sName, Age = sAge, TeachableClass = sClass };
            lst.Add(tch);
        }
    }
}
