using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal class Map
    {
        private Tile[,] map { get; set; }
        private Hero hero { get; set; }
        private Enemy[] enemy { get; set; }

        //Map width and height
        private int mapWidth;
        private int mapheight;

        private Random rng;

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies)
        {
            mapWidth = rng.Next(minWidth, maxWidth);
            mapheight = rng.Next(minHeight, maxHeight);

            map = new Tile[mapWidth, mapheight];

            enemy = new Enemy[numEnemies];

            //Create();

            //UpdateVision();
        }

    }
}
