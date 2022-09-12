using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6112_POE
{
    internal abstract class Character : Tile
    {
        protected int HP { get; set; }
        protected int maxHP { get; set; }
        protected int damage { get; set; }
        protected Tile[] CharacterVision = new Tile[4]; //North, east, south, west

        public enum Movement
        {
            NONE,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        public Character(int characterX, int characterY, string symbol = "H") : base(characterX, characterY)
        {

        }

        /// <summary>
        /// Attacks a target and decreases
        /// its health by the attacking character’s damage.
        /// </summary>
        /// <param name="target"></param>
        public virtual void Attack(Character target)
        {
            target.HP =- damage;
        }

        public bool IsDead()
        {
            if (HP < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange(Character target)
        {
            //As of project 1, character is barehanded
            if (DistanceTo(target) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines the
        /// absolute distance(number of spaces needed to move – e.g., diagonal is one
        /// up + one across = 2) between a character and its target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        private int DistanceTo(Character target)
        {

            int xDistance = X - target.X;
            //Convert from - to +
            if (xDistance < 0)
            {
                xDistance = xDistance * -1;
            }

            int yDistance = Y - target.Y;
            //Convert from - to +
            if (yDistance < 0)
            {
                yDistance = yDistance * -1;
            }

            //Addition
            int distance = xDistance + yDistance;

            return distance;
        }

        public void Move (Movement ReturnMove)
        {
            switch (ReturnMove)
            {
                case Movement.NONE:
                    break;
                case Movement.UP:
                    Y =- 1;
                    break;
                case Movement.DOWN:
                    Y =+ 1;
                    break;
                case Movement.LEFT:
                    X =- 1;
                    break;
                case Movement.RIGHT:
                    X =+ 1;
                    break;
                default:
                    break;
            }
        }

        public abstract Movement ReturnMove(Movement ReturnMove = 0);
    }
}
