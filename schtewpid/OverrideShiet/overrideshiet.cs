using System;

namespace OverrideShiet
{
    class Inhabitant
    {
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }

        public virtual void Kill()
        {
            Console.WriteLine($"{Name} has been eliminated.");
        }
    }

    class Student : Inhabitant
    {
        //override of polymorphic variable
        public override string Name { get => base.Name + " [STUDENT]"; }

        //override of method
        public override void Kill()
        {
            Console.WriteLine($"{Name} cannot be killed. Reason: Student");
        }
    }   

    class overrideshiet
    {
        static void Main(string[] args)
        {
            var y = new Inhabitant() { Name = "Matey", Age = 22 };
            y.Kill();


            var x = new Student() { Name = "Kevin", Age = 65 };
            x.Kill();
        }
    }
}
