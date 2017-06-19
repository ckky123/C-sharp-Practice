using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1
{
    class Slime : Monster
    {
        private int hp;
        public Slime () : base("slime")
        {
            hp = 500;
            base.hp = 261234;

        }

        public string attack()
        {
            return "Slime is attacking...";
        }

        public override string introduceSelf()
        {
            return base.introduceSelf()+ "I am Slime!";
        }
        public string say()
        {
            return base.introduceSelf()+"I am Slime!";
        }

    }
}
