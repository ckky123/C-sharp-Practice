using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1
{
    class villager : Creature
    {
        public villager(String name)
        {
            this.name = name;
        }
        public override string attack(Creature target)
        {

            return name + " can't attack " + target.name + "\n" + target.name + "HP: " + target.GetHP();
        }
        public String Talk()
        {
            return "Today's weather is nice!!";
        }
    }
}
