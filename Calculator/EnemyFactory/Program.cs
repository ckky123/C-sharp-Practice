using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyFactory
{
    public class EnemyFact
    {
        static void Main(string[] args)
        {
        }

        public object Create(bool isBoss)
        {
            if (isBoss)
            {
                return new BossEnemy();
            }
            return new NormalEnemy();
        }

    }
}
