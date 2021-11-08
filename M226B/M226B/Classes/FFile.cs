using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226B.Classes
{
    abstract class FFile
    {
        public string name { get; set; }
        public string fileText { get; set; }

        protected abstract string fileExtension { get; }


        
        public FFile(string Name, string Text)
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
        public virtual void GenerateFile()
        {
            try
            {
                var fullName = name + "." + fileExtension;
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fullName))
                {
                    File.Delete(fullName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fullName))
                {
                    // Add some text to file    
                    Byte[] txt = new UTF8Encoding(true).GetBytes(fileText);
                    fs.Write(txt, 0, txt.Length);

                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
