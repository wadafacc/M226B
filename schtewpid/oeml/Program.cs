using System;

namespace oeml
{
    public interface IPerson
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
    }
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
