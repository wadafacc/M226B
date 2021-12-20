using System;


delegate int NumChanger(int x);
namespace EventListener
{

    class delegateClass
    {
        class TestDelegate
        {
            static int num = 10;

            public static int AddNum(int p)
            {
                num += p;
                return num;
            }
            public static int MultNum(int q)
            {
                num *= q;
                return num;
            }
            public static int getNum()
            {
                return num;
            }
        }

        static void Main(string[] args)
        {
            //create delegate instances
            NumChanger nc1 = new NumChanger(AddNum);
            NumChanger nc2 = new NumChanger(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
