using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel
{
    internal class LearningLogic
    {
        private Problems activeProblem;
        private Timer solutionTimer;
        LearningTime learningTime;
        public Problems GetActiveProblem 
        {
            get
            {
                return activeProblem;
            }
            set { }
        }
        
        public void CheckAnswer(string answer)
        {
            foreach (char c in answer)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Svaret innehöll inte bara siffror.");
                    return;
                }
            }
            
            if (answer == activeProblem.solution)
                RightAnswer();
            else
                WrongAnswer();    
        }
        
        private void WrongAnswer()
        {
            MessageBox.Show("Din mamma");
        }

        private void RightAnswer()
        {
            MessageBox.Show("Deez nuts");
        }
        
        public LearningLogic(LearningTime learningTime)
        {
            activeProblem = new Problems();

            CreateTimer();
            this.learningTime = learningTime;
        }

        private Problems CreateProblem()
        {
            return new Problems();
        }

        private void CreateTimer()
        {
            solutionTimer = new Timer()
            {
                Interval = 1000,
            };
            solutionTimer.Tick += UppdateTime;
            solutionTimer.Start();
        }
        private int seconds = 0;
        private int minutes = 0;

        private void UppdateTime(object sender, EventArgs e)
        {
            if (++seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }

            learningTime.timeTextBox.Text = $"{minutes}m {seconds}s";
        }
    }
}
