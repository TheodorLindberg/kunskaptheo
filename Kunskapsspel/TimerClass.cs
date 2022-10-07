using Kunskapsspel.Scenes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Kunskapsspel
{
    internal class TimerClass
    {
        private Timer timer;
        private readonly MovementClass movmentClass;
        private readonly TestScene testScene;
        public TimerClass(TestScene testScene)
        {
            this.testScene = testScene;
            movmentClass = new MovementClass();

            Button btn = new Button()
            {
                Size = new Size(100,100),
                Location = new Point(100,100),
            };
            btn.Click += CreateTimer;
            testScene.gameForm.Controls.Add(btn);
            btn.BringToFront();
        }

        private void CreateTimer(object sender, EventArgs e)
        {
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
        }

        public void Stop()
        {
            timer.Stop();
        }

    }
}
