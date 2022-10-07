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
        public bool isCurrentlyInUse = false;
        public InteractableObject(Point ItemTopLeftPoint, Size ItemSize, Image image, GameForm form)
        {
            this.form = form;
            CreateBody(ItemTopLeftPoint, ItemSize, image);
        }

        public void CreateBody(Point ItemTopLeftPoint, Size ItemSize, Image image)
        {
            itemBody = new PictureBox()
            {
                Location = ItemTopLeftPoint,
                Size = ItemSize,
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            form.Controls.Add(itemBody);
        }

        public bool CanBeInteractedWith(Player player)                               // Change
        {
            if (itemBody.Location.Y <= 500)
                return false;
            
            return true;
        }
    }
}
