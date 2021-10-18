using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.IO; 



namespace M226B
{
    class Program
    {
        static void Main(string[] args)
        {
            //define path
            string filename = @"C:\Data\byteArray.bin";

            //define arrae
            byte[] byteArrayWrite = { 200, 201, 202, 203, 204, 205, 206, 207 };
            byte[] byteArrayRead = new byte[byteArrayWrite.Length];

            //create FileStream
            FileStream fs = new FileStream(filename, FileMode.Create);

            //write to file
            fs.Write(byteArrayWrite, 0, byteArrayWrite.Length);

            //read from file
            fs.Position = 0;
            fs.Read(byteArrayRead, 0, byteArrayRead.Length);

            // output: values of byte array
            for (int i = 0; i < byteArrayRead.Length; i++)
            {
                Console.Write (byteArrayRead[i] + ", ");       
            }
            
            //close filestream and delete file
            fs.Close();
            File.Delete(filename);
        }





        public int ReadByte()
        {
            return 0;
        }
        public int Read(byte[] buffer, int offset, int count)
        {
            return 0;
        }
        public void WriteByte()
        {

        }
        public void Write(byte[] buffer, int offset, int count)
        {

        }
        public void Flush()
        {

        }
        public void Close()
        {

        }
        public long Seek()
        {
            return 0;
        }
        //public abstract void SetLength(long value);
    }
}
