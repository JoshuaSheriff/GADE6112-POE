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
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {

        }

        private void Gamepad_Load(object sender, EventArgs e)
        {
            Map map = new Map(0, 15, 0, 15, 5);

            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    TextBox txtBox = new TextBox();
                    txtBox.Size = new Size(30, 10);
                    txtBox.Name = "txt" + x.ToString() + "_" + y.ToString();
                    txtBox.Location = new Point(x * 30, y * 30);
                    panel1.Controls.Add(txtBox);

                    if ((x == 0) || (x == 14))
                    {
                        txtBox.BackColor = Color.Black;
                    }
                    if ((y == 0) || (y == 14))
                    {
                        txtBox.BackColor = Color.Black;
                    }
                }
            }
        }
    }
}
