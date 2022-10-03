using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Kunskapsspel
{
    internal class TimerClass
    {
        private readonly Timer timer;
        private readonly MovementClass movment;
        public TimerClass(MovementClass movment)
        {
            this.movment = movment;
            timer = new Timer()
            {
                Interval = 20,
            };
            timer.Tick += TickEvent;
            timer.Start();

        }

        private void TickEvent(object sender, EventArgs e)
        {
            movment.Move();
        }

        public void Stop()
        {
            timer.Stop();
        }

    }
}
