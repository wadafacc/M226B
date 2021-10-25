using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226B.Classes
{
    class XmlFile : FFile
    {
        public XmlFile(string Name, string Text)
        {
            name = Name;
            fileText = Text;
        }

        public override void GenText()
        {

        }
    }
}
