using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go4Library
{
    public class Player
    {
        public string Name { get; private set; }
        public string Color { get; private set; }


        public Player(string name,string color) 
        {
            Name = name;
            Color = color;
        }

    }
}
