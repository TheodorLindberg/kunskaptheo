using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel.Scenes
{
    public class TestScene : GraficalScene
    {
        public TestScene(GameForm gameForm) : base(gameForm)
        {
            CreateBackground();
            CreateInteractableObjects();
        }

        public override void CreateBackground()
        {
            Debug.WriteLine(Path.GetFullPath("./Capybara.jpg"));

            background = new PictureBox()
            {
                Size = new Size(10000, 10000),
                Location = new Point(0,0),
                Image = Image.FromFile(@"./Resources/Capybara.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            form.Controls.Add(background);
            allPictureBoxes.Add(background);
        }
        public override void CreateInteractableObjects()
        {
            for (int i = 1; i <= 4; i++)
            {
                InteractableObject interactableObject = new InteractableObject(new Point(1500 * i, 500), new Size(300,300),Image.FromFile(@"./Resources/Capybara.jpg"), form);
                interactableObject.itemBody.BringToFront();
                allPictureBoxes.Add(interactableObject.itemBody);
                interactableObjects.Add(interactableObject);
            }
        }
    }
}
