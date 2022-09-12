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
        public Gamepad()
        {
            InitializeComponent();

            int[,] boxCoords;

            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    var txtBox = new TextBox();
                    txtBox.Name = "txt" + x + y;
                    txtBox.Location = new Point(x*10, y*10);
                    txtBox.Size = new Size(15, 10);

                }
            }
        }
    }
}
