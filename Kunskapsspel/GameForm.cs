using Kunskapsspel.Scenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel
{
    public partial class GameForm : Form
    {
        public InteractableObject interactableObject;
        private readonly InteractClass interact;
        private bool spaceDown = false;
        Player player;
        public GameForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            TimerClass timer = new TimerClass(new TestScene(this));
            interact = new InteractClass();
            player = new Player(this, Image.FromFile("Capybara.jpg"));
            


            KeyDown += GameForm_KeyDown;
            KeyUp += GameForm_KeyUp;
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
                spaceDown = false;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (spaceDown)
                return;
            if (e.KeyData == Keys.Space)
            {
                interact.Interact(interactableObject, player);
                spaceDown = true;
            }
        }
    }
}
