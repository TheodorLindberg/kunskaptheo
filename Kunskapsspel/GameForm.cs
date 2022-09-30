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
        public PictureBox tempPb;
        public GameForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MovementClass mv = new MovementClass(this);
            TimerClass timer = new TimerClass(mv);
            InteractableObject interactableObject = new InteractableObject(new Point(0, 0), new Size(300, 200), this);

            SetUP();
        }

        private void SetUP()
        {
            tempPb = new PictureBox()
            {
                Size = new Size(3000, 3000),
                Location = new Point(0, 0),
                Image = Image.FromFile("Capybara.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            this.Controls.Add(tempPb);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
