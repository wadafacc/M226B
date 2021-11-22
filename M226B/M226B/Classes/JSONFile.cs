using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace M226B.Classes
{
    class JSONFile : FFile
    {

        public JSONFile(string Name, object Data): base(Name, JsonSerializer.Serialize(Data)) {}
        protected override string FileExtension { get; } = "json";

        public override void GenText()
        {
            FileText = JsonSerializer.Serialize(FileText);
        }
    }
}
