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
        public string Name { get; set; }
        public string FileText { get; set; }

        protected string FileExtension { get; }


        
        public FFile(string name, string text, string fileExtension)
        {
            Name = name;
            FileText = text;
            FileExtension = fileExtension;
        }





        public virtual void GenText()
        {
            FileText = "Henlo Wjorld";
        }

        public virtual void GenTrash()
        {
            var fullName = Name + "." + FileExtension;
            try
            {
                if (!File.Exists(fullName))
                {
                    Console.WriteLine("Error: There is no such File.");
                }
                else
                {

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e + "\n Oops.");
            }
        }


        /// <summary>
        /// Generates a File based on the Object's attributes
        /// </summary>
        public virtual void GenFile()
        {
            try
            {
                var fullName = Name + "." + FileExtension;
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fullName))
                {
                    File.Delete(fullName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fullName))
                {
                    // Add some text to file    
                    Byte[] txt = new UTF8Encoding(true).GetBytes(FileText);
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
