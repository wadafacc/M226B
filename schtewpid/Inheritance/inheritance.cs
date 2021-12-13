using System;

namespace Inheritance
{
    public class Person
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
    public class Student : Person
    {
        public string Class { get; set; }
        public string Fees{ get; set; }
        public string Marks { get; set; }
        public string Grade { get; set; }
    }
    public class Staff : Person
    {
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
    class inheritance
    {
        static void Main(string[] args)
        {
            Student std = new Student()
            {
                Id = 1,
                Name = "Hans",
                Address = "Musterstreet 14",
                Phone = "34567876543",
                Class = "BMI1a",
                Fees = "2.00",
                Marks="6",
                Grade="4"
                
            };

            Console.WriteLine(std.Name);
        }
    }
}
