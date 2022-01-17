using System;

namespace deleginsteadswitch
{
    delegate void Delegate_func();
    class Program
    {
        static void Main(string[] args)
        {
            //more code reusability using delegates (delegate = verweisen --> our Delegate_func delegates to the functions in the SinglecastDelegates class)
            //Github (What not to do): https://github.com/ReisMiner/CustomCommands/blob/master/src/main/java/xyz/reisminer/chtop/Bot.java heheboye :))
            //Here are a couple ways of *what* to do / how to use delegates
            
            //option 1
            Delegate_func func1 = SingleCastDelegates.Nyet;
            func1();

            //option 2
            Delegate_func func2 = new Delegate_func(SingleCastDelegates.Shiet);
            func2();

            //option 3
            SingleCastDelegates obj = new SingleCastDelegates();
            Delegate_func func3 = obj.Hmm;
            func3();
        }
    }
}
