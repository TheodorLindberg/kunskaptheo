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
    public partial class LearningTime : System.Windows.Forms.Form
    {
        public Label timeTextBox;
        private TimerClass timerClass;
        public LearningTime(TimerClass timerClass)
        {
            this.timerClass = timerClass;
            InitializeComponent();
            timerClass.Stop();
            FormClosing += LearningTime_FormClosing;
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, Screen.PrimaryScreen.Bounds.Height);
            LearningLogic learningLogic = new LearningLogic(this);
            LearningScene learningScene = new LearningScene(this, learningLogic);
        }

        private void LearningTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerClass.Start();
        }
    }
}
