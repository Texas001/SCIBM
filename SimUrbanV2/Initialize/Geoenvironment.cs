using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimUrbanV2.Agents;
using System.Reflection;

namespace SimUrbanV2.Initialize
{
    class Geoenvironment
    {

        /// <summary>
        /// Initialize block properties
        /// </summary>
        /// <param name="block_jsonfile"></param>
        public void Iniblocks(ref string block_jsonfile, ref List<Block> resultlist) {
            StreamReader reader = File.OpenText(block_jsonfile);
            JsonTextReader jsonTextReader = new JsonTextReader(reader);
            JArray array = (JArray)JToken.ReadFrom(jsonTextReader);
            //List<Block> testlist = new List<Block>();
            foreach (var item in array)
            {
                resultlist.Add(new Block((long)item["uid"], item["Name"].ToString()));
            }
            reader.Close();            
        }




    }
}
