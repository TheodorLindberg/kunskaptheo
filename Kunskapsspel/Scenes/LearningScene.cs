using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel.Scenes
{
    internal class LearningScene
    {

        public LearningScene(LearningTime learningTime)
        {
            CreateObjects(learningTime);
        }

        private void CreateObjects(LearningTime learningTime)
        {
            TextBox problemTextBox = new TextBox()
            {
                Size = new Size(learningTime.Width, 300),
                Location = new Point(0, 0),
                Font = new Font(new FontFamily("Comic Sans MS"), 25),
                Text = "Supersvårt problem D:",
                TabStop = false,
                Enabled = false,
            };
            learningTime.Controls.Add(problemTextBox);

            TextBox answerTextBox = new TextBox()
            {
                Size = new Size(learningTime.Width, 300),
                Location = new Point(0, problemTextBox.Height),
                Font = new Font(new FontFamily("Comic Sans MS"), 25),
                Text = "Lösning :)",
                TabStop = false,
            };
            learningTime.Controls.Add(answerTextBox);

            Button button = new Button()
            {
                Size = new Size(100, 100),
                Location = new Point(500, 600),

            };
            learningTime.Controls.Add(button);
            button.Click += Button_Click;

            Label timeTextBox = new Label()
            {
                Size = new Size(learningTime.Width, 600),
                Location = new Point(0, problemTextBox.Height + 300),
                Font = new Font(new FontFamily("Comic Sans MS"), 25),
                Text = "0",
            };
            learningTime.Controls.Add(timeTextBox);
            learningTime.timeTextBox = timeTextBox;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            PlaySound();

        }

        private void PlaySound()
        {
            SoundPlayer simpleSound = new SoundPlayer("vine-boom.wav");
            simpleSound.Play();
        }
    }
}
