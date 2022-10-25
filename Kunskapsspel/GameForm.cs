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
    public partial class GameForm : Form
    {
        readonly TestScene testScene;
        public GameForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            testScene = new TestScene(this);
            TimerClass timer = new TimerClass(testScene, this);

            LearningTime learningTime = new LearningTime();
            learningTime.Show();
        }
    }
}
