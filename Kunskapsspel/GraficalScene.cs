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
        public List<PictureBox> interactableObjects = new List<PictureBox>();
        public List<PictureBox> allPictureBoxes = new List<PictureBox>();
        public GameForm gameForm;

        public GraficalScene(GameForm gameForm)
        {
            this.gameForm = gameForm;
        }

        public virtual void CreateInteractableObjects() { }

        public virtual void CreateBackground() { }
    }
}
