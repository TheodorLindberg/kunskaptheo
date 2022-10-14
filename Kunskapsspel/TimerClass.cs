using Kunskapsspel.Scenes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Kunskapsspel
{
    internal class TimerClass
    {
        private Timer timer;
        private readonly MovementClass movmentClass;
        private readonly TestScene testScene;
        private readonly GameForm gameForm;
        private bool spaceDown = false;
        private InteractClass interact;
        Player player;
        public TimerClass(TestScene testScene, GameForm gameForm)
        {
            this.testScene = testScene;
            this.gameForm = gameForm;
            movmentClass = new MovementClass();

            Button btn = new Button()
            {
                Size = new Size(100,100),
                Location = new Point(100,100),
            };
            btn.Click += StartGame;
            testScene.gameForm.Controls.Add(btn);
            btn.BringToFront();
        }

        private void StartGame(object sender, EventArgs e)
        {
            interact = new InteractClass();
            player = new Player(gameForm, Image.FromFile("Capybara.jpg"));

            Button btn = (Button)sender;
            btn.Hide();
            timer = new Timer()
            {
                Interval = 20,
            };
            timer.Tick += TickEvent;
            timer.Start();
        }

        private void TickEvent(object sender, EventArgs e)
        {
            movmentClass.Move(testScene.background, testScene.interactableObjects);
            Interact();
        }
        private void Interact()
        {
            if (Keyboard.IsKeyUp(Key.Space))
                spaceDown = false;

            if (spaceDown)
                return;

            if (Keyboard.IsKeyDown(Key.Space))
            {
                spaceDown = true;
                interact.Interact(testScene.interactableObjects, player);
            }
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
