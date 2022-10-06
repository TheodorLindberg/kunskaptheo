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
        public PictureBox tempBackgroundPb;
        public InteractableObject interactableObject;
        private InteractClass interact;
        private bool spaceDown = false;
        public GameForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MovementClass mv = new MovementClass(this);                  // Can remove form parameter when you add grafical class
            TimerClass timer = new TimerClass(mv);
            interact = new InteractClass();
            Player player = new Player();
            Controls.Add(player.body);
            

            KeyDown += GameForm_KeyDown;
            KeyUp += GameForm_KeyUp;

            SetUp();
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
                interact.Interact(interactableObject);
                spaceDown = true;
            }
        }

        private void SetUp()
        {
            tempBackgroundPb = new PictureBox()
            {
                Size = new Size(3000, 3000),
                Location = new Point(0, 0),
                Image = Image.FromFile("Capybara.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            this.Controls.Add(tempBackgroundPb);
        }

    }
}
