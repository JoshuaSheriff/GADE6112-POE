using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6112_POE
{
    public partial class Gamepad : Form
    {
        private Random rng = new Random();
        int mapWidth;
        int mapHeight;

        private Tile[,] map { get; set; }
        private string[,] stringMap { get; set; }
        private Hero hero { get; set; }
        private Enemy[] enemy { get; set; }

        private int enemyCounter = 0;


        public Gamepad()
        {
        InitializeComponent();
        }

    private void btnBegin_Click(object sender, EventArgs e)
        {

        }

        private void Gamepad_Load(object sender, EventArgs e)
        {
            //Code for Tile[,]
            mapWidth = rng.Next(4, 15);
            mapHeight = rng.Next(4, 15);

            map = new Tile[15, 15];
            stringMap = new string[15, 15];

            //readMap();

            enemy = new Enemy[rng.Next(1,5)];

            hero = new Hero(1, 1, 10);
            //map[1,1] = hero;
            //Create(Tile.TileType.HERO);

            //foreach (Enemy enemies in enemy)
            //{

            //    Create(Tile.TileType.ENEMY);
            //    enemyCounter++;
            //}

            //Physical Display
                foreach (Enemy enemy in enemy)
            {
                stringMap[rng.Next(1, mapWidth-1), rng.Next(1, mapHeight-1)] = "SC";
            }
            
                bool flag = false;
                while (flag == false)
            {
                if (stringMap[rng.Next(1, mapWidth - 1), rng.Next(1, mapHeight - 1)] == "SC")
                {
                }
                else
                {
                    stringMap[rng.Next(1, mapWidth - 1), rng.Next(1, mapHeight - 1)] = "H";
                    flag = true;
                }
            }

            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    TextBox txtBox = new TextBox();
                    txtBox.Size = new Size(30, 10);
                    txtBox.Name = "txt" + x.ToString() + "_" + y.ToString();
                    txtBox.Text = stringMap[x, y];
                    txtBox.Location = new Point(x * 30, y * 30);
                    panel1.Controls.Add(txtBox);

                    if ((x == 0) || (x == 15-1))
                    {
                        txtBox.BackColor = Color.Black;
                    }
                    if ((y == 0) || (y == 15-1))
                    {
                        txtBox.BackColor = Color.Black;
                    }
                }
            }
            //if (map[1, 1] == hero)
            //{
            //    txtBox.Text = "H";
            //}
        }

        //public void readMap()
        //{
        //    for (int x = 0; x < 15; x++)
        //    {
        //        for (int y = 0; y < 15; y++)
        //        {
        //            if (map[x, y] == hero)
        //            {
        //                stringMap[x, y] = "H";
        //            }
        //            else
        //            {
        //                stringMap[x, y] = ".";
        //            }
        //        }
        //    }
        //}

        //private Tile Create(Tile.TileType type)
        //{
        //    int createX = rng.Next(mapWidth);
        //    int createY = rng.Next(mapHeight);

        //    switch (type)
        //    {
        //        case Tile.TileType.HERO:
        //            hero = new Hero(createX, createY, 10);
        //            map[createX, createY] = hero;
        //            break;
        //        case Tile.TileType.ENEMY:
        //            Swamp_Creature swamp_Creature = new Swamp_Creature(createX, createY);
        //            enemy[enemyCounter] = swamp_Creature;
        //            map[createX, createY] = enemy[enemyCounter];
        //            break;
        //    }
        //    return map[createX, createY];
        //}
    }
}
