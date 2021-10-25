using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226B.Classes
{
    class FFile
    {
        public string name;
        public string fileText;

        public FFile()
        {

        }
        public FFile(string Name, string Text) : this()
        {
            name = Name;
            fileText = Text;
        }





        public virtual void GenText()
        {
            fileText = "Henlo Wjorld";
        }

        /// <summary>
        /// Generates a File based on the Object's attributes
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        public virtual void GenerateFile(string name, string text)
        {
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(name))
                {
                    File.Delete(name);
                }

                // Create a new file     
                using (FileStream fs = File.Create(name))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes(text);
                    fs.Write(title, 0, title.Length);

                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
