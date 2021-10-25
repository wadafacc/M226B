using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226B.Classes
{
    class TxtFile : FFile
    {

        public TxtFile(string Name, string Text)
        {
            name = Name;
            fileText = Text;
        }

        public override void GenText()
        {
            
        }


        public virtual void GenerateFile()
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
                    Byte[] title = new UTF8Encoding(true).GetBytes(fileText);
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
