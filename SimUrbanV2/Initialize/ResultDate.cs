using Newtonsoft.Json;
using SimUrbanV2.Agents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SimUrbanV2.Initialize
{
    class ResultDate
    {
        public void ExportBlockDate_json(ref List<Block> blocks, string filePath = "Unknown") {
            // export BlockResult jsonfile
            string str = JsonConvert.SerializeObject(blocks);
            if (filePath == "Unknown"){
                var appPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                filePath = Path.Combine(appPath, "Test2.json");
            }
            StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine(str);
            writer.Flush();
        }

    }
}
