using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal abstract class Enemy : Character
    {
        protected int rng;

        public Enemy(int enemyX, int enemyY, int enemyDamage, int enemyCurrentHP ,int enemyMaxHP, char symbol) : base(enemyX, enemyY)
        {
            
        }

        public override string ToString()
        {
            return "EnemyClassName at [X, Y] (Amount DMG)";
        }
    }

    
}
