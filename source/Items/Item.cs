using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPAdventureGame
{
    public abstract class Item
    {
        public virtual string Name { get; set; } = "";
        public bool SingleUse { get; set; }
        public bool CanTake { get; set; } = true;

        public virtual void Use(string source)
        {
            throw new NotImplementedException();
        }

    }
}