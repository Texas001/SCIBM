using System;
using System.Collections.Generic;
using System.Text;

namespace SimUrbanV2.Agents
{
    class Block
    {
        private long uid = 0;
        private string name = "Unknown";
        private int popnum = 0;

        public Block(){
      
        }

        public Block(long uid, string name)
        {
            this.uid = uid;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public long Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public int Popnum { get => popnum; set => popnum = value; }
    }
}
