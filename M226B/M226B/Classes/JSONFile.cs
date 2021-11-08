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

        public JSONFile(string Name, object data): base(Name, JsonSerializer.Serialize(data))
        {
            name = Name;

        }
        protected override string fileExtension { get; } = "json";

        public override void GenText()
        {

        }
    }
}
