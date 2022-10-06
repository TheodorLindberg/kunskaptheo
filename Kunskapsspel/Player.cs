using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel
{
    internal class Player
    {
        public PictureBox body;
        public Player()
        {
            CreateBody();
        }

        private void CreateBody()
        {
            body = new PictureBox()
            {
                Size = new Size(300, 300),
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 150, Screen.PrimaryScreen.Bounds.Height / 2 - 150),
                Image = Image.FromFile("Capybara.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };


        }
    }
}
