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
    public partial class GameForm : System.Windows.Forms.Form
    {
        public PictureBox background;
        readonly TestScene testScene;
        public TimerClass timerClass;

        Player player;


        private readonly StartScreenForm startScreenForm;
        public GameForm(StartScreenForm startScreenForm)
        {
            InitializeComponent();
            this.startScreenForm = startScreenForm;
            this.WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            testScene = new TestScene(this);
            background = testScene.background;
            new TimerClass(TickEvent, testScene, this);
            
            CreateExitButton();
            BackColor = Color.Green;

            player = new Player(this);

        }

        private void CreateExitButton()
        {
            Button exitBtn = new Button()
            {
                Size = new Size(50,50),
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 50, 0),
                Text = "Exit",
                TabStop = false,
                FlatStyle = FlatStyle.Flat,
            };
            Controls.Add(exitBtn);
            exitBtn.BringToFront();
            exitBtn.Click += ExitBtn_Click;


            Image image = Image.FromFile(@"./Resources/Capybara.jpg");
            PictureBox box = new PictureBox()
            {
                Size = new Size(100,100),
                Location = new Point(200,200),
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Parent = background
            };

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            startScreenForm.Show();
        }
        private void TickEvent()
        {
            Console.WriteLine("Update");
            player.Update();
            this.Update();
            
        }

    }
}
