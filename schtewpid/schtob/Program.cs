using System;

namespace schtob
{
    interface IInderface
    {
        public string DoShiet(string value);
    }

    class StubIInderface : IInderface
    {
        public string DoShiet(string value)
        {
            return value + "yeeee";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // unit test code
            var stub = new StubIInderface();
            stub.DoShiet("fuckoff"); 
        }
    }
}
