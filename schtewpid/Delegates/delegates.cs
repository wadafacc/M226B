using System;
using System.IO;

namespace Delegates
{
delegate void printString(string s);
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream("c:\\message.txt",
            FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void SendString(printString ps)
        {
            ps("TestString");
        }
        class delegates
        {
            static void Main(string[] args)
            {
                printString ps1 = new printString(WriteToScreen);
                printString ps2 = new printString(WriteToFile);
                SendString(ps1);
                SendString(ps2);
                Console.ReadKey();
            }
        }
    }
}
