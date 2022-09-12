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
        private int mapHeight;

        private Random rng;

        public Map()
        {

        }
        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies)
        {
            mapWidth = rng.Next(minWidth, maxWidth);
            mapHeight = rng.Next(minHeight, maxHeight);

            map = new Tile[mapWidth, mapHeight];
            
            enemy = new Enemy[numEnemies];

            Create(Tile.TileType.HERO);

            foreach (Enemy enemies in enemy)
            {
                Create(Tile.TileType.ENEMY);

            }
            //UpdateVision();
        }

        //public void UpdateVision()
        //{
            
        //}

        private Tile Create(Tile.TileType type)
        {
            int createX = rng.Next(mapWidth);
            int createY = rng.Next(mapHeight);

            switch (type)
            {
                case Tile.TileType.HERO:      
                    hero = new Hero(createX, createY, 10);
                    map[createX, createY] = hero;
                    break;
                case Tile.TileType.ENEMY:
                    //enemy = new Enemy(rng.Next(mapWidth), rng.Next(mapHeight);
                    map[createX, createY] = enemy[0];
                    break;
             }
            return map[createX, createY];
        }
    }
}
