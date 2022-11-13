using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel.Scenes
{
    class StartingScene
    {
        readonly StartScreenForm startScreenForm;
        public StartingScene(StartScreenForm startScreenForm)
        {
            startScreenForm.WindowState = FormWindowState.Maximized;
            startScreenForm.FormBorderStyle = FormBorderStyle.None;
            this.startScreenForm = startScreenForm;
            CreateControls();
        }

        private void CreateControls()
        {
            PictureBox background = new PictureBox()
            {
                Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height),
                Location = new Point(0, 0),
                Image = Image.FromFile(@"./Resources/Capybara.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            startScreenForm.Controls.Add(background);


            Button exitBtn = new Button()
            {
                Size = new Size(50, 50),
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 50, 0),
                Text = "Exit",
                TabStop = false,
            };
            startScreenForm.Controls.Add(exitBtn);
            exitBtn.BringToFront();
            exitBtn.Click += ExitBtn_Click;


            Button startGameBtn = new Button()
            {
                Size = new Size(50, 50),
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 50, 600),
                Text = "Start",
                TabStop = false,
            };
            startScreenForm.Controls.Add(startGameBtn);
            startGameBtn.BringToFront();
            startGameBtn.Click += StartGame_Click;


            ComboBox chapters = new ComboBox()
            {
                Location = new Point(50, 50),
                Size = new Size(500, 500),
                Font = new Font(new FontFamily("Comic Sans MS"), 25),
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            chapters.Items.Add("alkoholism");
            startScreenForm.Controls.Add(chapters);
            chapters.BringToFront();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(startScreenForm);
            gameForm.Show();
            startScreenForm.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            startScreenForm.Close();
        }

    }
}
