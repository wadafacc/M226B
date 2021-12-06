using System;

namespace OverrideShiet
{
    class BaseClass
    {
        public virtual string Text { get; set; }

        public virtual void Method()
        {
            Console.WriteLine("Base Text ");
        }
    }

    class DerivedClass : BaseClass
    {
        //override of polymorphic variable
        public override string Text {
            get => base.Text;
            set => base.Text = "Not quite Base Text"; 
        }

        //override of method
        public override void Method()
        {
            Console.WriteLine("Not quite quite Base text");
        }
    }

    class overrideshiet
    {
        static void Main(string[] args)
        {
            var y = new BaseClass();
            y.Method();


            var x = new DerivedClass();
            x.Method();
        }
    }
}
