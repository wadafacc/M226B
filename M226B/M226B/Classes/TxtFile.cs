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

        public TxtFile(string Name, string Text) : base(Name, Text)
        {
            
        }

        protected override string fileExtension { get; } = "txt";

        public override void GenText()
        {
            fileText = "hjello";
        }
    }
}
