using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimUrbanV2.Initialize
{
    class SyntheticPop
    {
        
        public void test() {
            Dictionary<int, Person> testdic = new Dictionary<int, Person>();
            for (int i = 0; i < 999; i++)
            {
                testdic.Add(i, new Person());
            }
            foreach (var item in testdic)
            {
                Console.WriteLine(item.Value);
            }
        }
        public void IniPop(ref string synpop_jsonfile,ref List<Person> pop_Rawlist)
        {
            StreamReader reader = File.OpenText(synpop_jsonfile);
            JsonTextReader jsonTextReader = new JsonTextReader(reader);
            JArray array = (JArray)JToken.ReadFrom(jsonTextReader);
            //List<Block> testlist = new List<Block>();
            foreach (var item in array)
            {
                pop_Rawlist.Add(new Person());
            }
            reader.Close();

        }

    }
}
