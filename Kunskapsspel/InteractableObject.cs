using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel
{
    public class InteractableObject
    {
        public PictureBox itemBody;
        private readonly GameForm form;
        public InteractableObject(Point ItemTopLeftPoint, Size ItemSize, GameForm form)
        {
            this.form = form;
            CreateBody(ItemTopLeftPoint, ItemSize);
        }

        public void CreateBody(Point ItemTopLeftPoint, Size ItemSize)
        {
            itemBody = new PictureBox()
            {
                Location = ItemTopLeftPoint,
                Size = ItemSize,
                Image = Image.FromFile("Capybara.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            form.Controls.Add(itemBody);
        }
    }
}
