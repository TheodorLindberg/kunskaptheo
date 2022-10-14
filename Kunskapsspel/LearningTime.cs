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
    public partial class LearningTime : Form
    {
        public LearningTime()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, Screen.PrimaryScreen.Bounds.Height);
            LearningScene learningScene = new LearningScene(this);
        }
    }
}
