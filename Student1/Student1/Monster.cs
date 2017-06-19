using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student1
{
    class Monster:Creature
    {
        private int X;
        private int Y;

        public void Move(direction  dir)
        {
            switch (dir)
            {
                case direction.UP:
                    Y += 1;
                    break;
                case direction.DOWN:
                    Y -= 1;
                    break;
                case direction.LEFT:
                    X += 1;
                    break;
                case direction.RIGHT:
                    X -= 1;
                    break;
            }

        }

        
        public Monster(string name)
        {
            this.name = name;
        }
        public Monster(string name, int power)
        {
            this.name = name;
            this.power = power;
        }

        public string ReportPosition()
        {
            Move(direction.DOWN);
            Move(direction.DOWN);
            Move(direction.DOWN);
            Move(direction.LEFT);
            return "mosnter is at("+X+","+Y +")";
        }

        public virtual string introduceSelf()
        {
            return "I am a monster!!!";
        }



       
        //.............more
    }
}
