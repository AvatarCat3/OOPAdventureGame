using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPAdventureGame
{
    public abstract class Character
    {
        public string Name { get; set; }
        public Character(string name){
            Name = name;
        }
    }
}