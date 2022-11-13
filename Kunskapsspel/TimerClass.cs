using Kunskapsspel.Scenes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Kunskapsspel
{
    public class TimerClass
    {
        private Timer timer;
        private readonly MovementClass movmentClass;
        private readonly TestScene testScene;
        private readonly GameForm gameForm;
        private bool spaceDown = false;
        private InteractClass interact;
        Player player;

        public delegate void TickHandler();

        private TickHandler handler;
        public TickHandler Tick => handler;

        public TimerClass(TickHandler handler, TestScene testScene, GameForm gameForm)
        {
            this.handler = handler;
            this.testScene = testScene;
            this.gameForm = gameForm;
            StartGame();
        }

        private void StartGame()
        {
            interact = new InteractClass();

            timer = new Timer()
            {
                Interval = 20,
            };
            timer.Tick += _tick;
            timer.Start();
        }

        private void _tick(object sender, EventArgs args)
        {
            handler.Invoke();
        }

        private void Interact()
        {
            if (spaceDown)
                return;

            spaceDown = true;
            interact.Interact(testScene.interactableObjects, player, this);
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Start()
        {
            timer.Start();
        }
    }
}
