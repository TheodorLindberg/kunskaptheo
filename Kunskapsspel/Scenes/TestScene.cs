using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel.Scenes
{
    internal class TestScene : GraficalScene
    {
        public TestScene(GameForm gameForm) : base(gameForm)
        {
            CreateBackground();
            CreateInteractableObjects();
        }

        public override void CreateBackground()
        {
            background = new PictureBox()
            {
                Size = new Size(10000, 10000),
                Location = new Point(-20, -20),
                Image = Image.FromFile("Capybara.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            gameForm.Controls.Add(background);
            allPictureBoxes.Add(background);
        }
        public override void CreateInteractableObjects()
        {
            for (int i = 1; i <= 4; i++)
            {
                InteractableObject interactableObject = new InteractableObject(new Point(1500 * i, 500), new Size(300,300),Image.FromFile("Capybara.jpg"), gameForm);
                interactableObject.itemBody.BringToFront();
                allPictureBoxes.Add(interactableObject.itemBody);
                interactableObjects.Add(interactableObject.itemBody);
            }
        }
    }
}
