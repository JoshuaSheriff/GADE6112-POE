using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal class Swamp_Creature : Enemy
    {
        public Swamp_Creature(int scX, int scY) : base(scX, scY, 1, 10, 10, "SC")
        {

        }

        public override Movement ReturnMove(Movement ReturnMove)
        {
            Obstacle wall = new Obstacle(X, Y);
            switch (rng.Next(3))
            {
                case 0:
                    ReturnMove = Movement.UP;
                    if (CharacterVision[0] == wall)
                    {
                        
                    }
                    break;
                case 1:
                    ReturnMove = Movement.DOWN;
                    break;
                case 2:
                    ReturnMove = Movement.LEFT;
                    break;
                case 3:
                    ReturnMove = Movement.RIGHT;
                    break;
                default:
                    break;
            }

            return ReturnMove;
        }
    }
}
