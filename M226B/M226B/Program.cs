using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.IO;
using M226B.Classes;

/// <summary>
/// Reverse Trashcan :>
/// 
/// Functionality:
/// - generate Files
/// - rename Files
/// - fill files with shite
/// 
/// </summary>
namespace M226B
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONFile newfile = new JSONFile("eeeeeeeeeeeeeeeeeee", data: new Data() { Field="yee", Value= "yeeet"});
            newfile.GenerateFile();
            Console.WriteLine(newfile.fileText);
        }
    }
}
