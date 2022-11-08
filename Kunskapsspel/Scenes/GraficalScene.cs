using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel
{
    public class GraficalScene
    {
        public PictureBox background;
        public List<InteractableObject> interactableObjects = new List<InteractableObject>();
        public List<PictureBox> allPictureBoxes = new List<PictureBox>();
        public Form form;

        public GraficalScene(Form form)
        {
            this.form = form;
        }

        public virtual void CreateInteractableObjects() { }

        public virtual void CreateBackground() { }
    }
}
