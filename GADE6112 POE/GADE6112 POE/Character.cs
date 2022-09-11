using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal abstract class Character : Tile
    {
        protected int HP { get; set; }
        protected int MaxHP { get; set; }
        protected int Damage { get; set; }
        protected Tile[] CharacterVision = new Tile[4]; //North, east, south, west

        public enum Movement
        {
            NONE,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        public Character(int characterX, int characterY, char symbol = 'H') : base(characterX, characterY)
        {

        }
    }
}
