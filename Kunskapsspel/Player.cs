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
    public class Player
    {
        public PictureBox body;
        private Size bodySize = new Size(200,200);

        public int LeftLocation 
        { 
            get
            {
                return body.Location.X;
            } 
            set { }
        }
        public int RightLocation
        {
            get
            {
                return body.Location.X + body.Width;
            }
            set { }
        }

        public int TopLocation
        {
            get
            {
                return body.Location.Y;
            }
            set { }
        }

        public int BottomLocation
        {
            get
            {
                return body.Location.Y + body.Height;
            }
            set { }
        }
        public Player(Form form, Image image)
        {
            CreateBody(form, image);
        }

        private void CreateBody(Form form, Image image)
        {
            body = new PictureBox()
            {
                Size = bodySize,
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - bodySize.Width/2, Screen.PrimaryScreen.Bounds.Height / 2 - bodySize.Height / 2),
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            form.Controls.Add(body);
            body.BringToFront();
        }
    }
}
