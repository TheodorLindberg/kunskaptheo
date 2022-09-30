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
    internal class InteractableObject
    {
        PictureBox itemBody;
        GameForm form;
        public InteractableObject(Point ItemTopLeftPoint, Size ItemSize, GameForm form)
        {
            this.form = form;
            CreateBody(ItemTopLeftPoint, ItemSize);
        }

        public void CreateBody(Point ItemTopLeftPoint, Size ItemSize)
        {
            itemBody = new PictureBox()
            {
                Name = "item",
                Location = ItemTopLeftPoint,
                Size = ItemSize,
                Image = Image.FromFile("Capybara.jpg"),
            };
            form.Controls.Add(itemBody);
        }
    }
}
