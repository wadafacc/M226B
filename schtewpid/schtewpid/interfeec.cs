using System;

namespace schtewpid
{
    public interface IInterface
    {
        public void ShietStuff();
    }
    public class Processingdings : IInterface
    {
        public void ShietStuff()
        {
            Console.WriteLine("randomShiet");
        }
    }
    public class Processingdingsv2 : IInterface
    {
        public void ShietStuff()
        {
            Console.WriteLine("Anoda Random Shiet");
        }
    }



    class interfeec
    {
        static void Main(string[] args)
        {
            Processingdings thisObject = new Processingdings();
            Processingdingsv2 thisObjectv2 = new Processingdingsv2();
            thisObject.ShietStuff();
            thisObjectv2.ShietStuff();
        }
    }
}
