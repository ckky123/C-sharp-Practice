using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1
{
    class Creature
    {
        protected int hp=100;

        public string name;
        public int power;
        public int GetHP()
        {
            return hp;
        }

        public virtual string attack( Creature target)
        {
            
            Random random = new Random();
            int inj = random.Next(power / 2, power);

            target.Injured(inj);
            return name + " attack " + target.name + "\n" +target.name+"HP: "+target.GetHP();
        }

        public void Injured(int injuredPoint)
        {
            hp -= injuredPoint;
        }
    }
}
