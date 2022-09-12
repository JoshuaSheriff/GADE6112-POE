using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal class Hero : Character
    {

        public Hero(int heroX, int heroY, int heroHP) :base(heroX, heroY)
        {
            HP = heroHP;
            maxHP = heroHP;
            damage = 2;
        }

        public override Movement ReturnMove(Movement ReturnMove = Movement.NONE)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Player Stats:" +
                $"\n HP: {HP}/{maxHP}" +
                $"Damage: {damage}" +
                $"[{X},{Y}]"; 
        }
    }
}
