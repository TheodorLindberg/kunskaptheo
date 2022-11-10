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
        StartScreenForm startScreen;
        public StartingScene(StartScreenForm startScreen)
        {
            startScreen.WindowState = FormWindowState.Maximized;
            startScreen.FormBorderStyle = FormBorderStyle.None;
            this.startScreen = startScreen;
            CreateButtons();
        }

        private void CreateButtons()
        {
            Button exitBtn = new Button()
            {
                Size = new Size(50, 50),
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 50, 0),
                Text = "Exit",
                TabStop = false,
            };
            startScreen.Controls.Add(exitBtn);
            exitBtn.BringToFront();
            exitBtn.Click += ExitBtn_Click;


            Button startGameBtn = new Button()
            {
                Size = new Size(50, 50),
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 50, 600),
                Text = "Start",
                TabStop = false,
            };
            startScreen.Controls.Add(startGameBtn);
            startGameBtn.BringToFront();
            startGameBtn.Click += StartGame_Click;
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            startScreen.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            startScreen.Close();
        }

    }
}
