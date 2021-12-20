using System;

namespace schtob
{
    public interface IInderface
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void work();
        public void schlep();
    }
    public class Stub : IInderface
    {
        public string Name { set; get; }

        public int Age { set; get; }
        public Stub()
        {
            Age = 50;
            Name = "Georgy Zhukov";
        }
        public void work()
        {
            Console.WriteLine("commanding the tanks");
        }
        public void schlep()
        {
            Console.WriteLine("recovering from commanding");
        }
    }
    public class stubs
    {
        public void main(string[] args)
        {
            Stub Georgy = new Stub();
            Console.WriteLine(Georgy.Name, Georgy.Age);
            Georgy.schlep();
            Georgy.work();
        }
    }
}
