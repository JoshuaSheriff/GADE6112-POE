using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal abstract class Tile
    {
        protected int X { get; set; }
        protected int Y { get; set; }

        public enum TileType
        {
            HERO,
            ENEMY,
            GOLD,
            WEAPON
        }

        public Tile()
        {
            X = 0;
            Y = 0;
        }
    }
}
