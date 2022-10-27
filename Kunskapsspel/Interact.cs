using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Kunskapsspel
{
    internal class InteractClass
    {
        public InteractClass()
        {


        }

        public void Interact(List<InteractableObject> interactableObjects, Player player, TimerClass timerClass)
        {
            if (!Keyboard.IsKeyDown(Key.Space))
                return;
            foreach (InteractableObject interactableObject in interactableObjects)
            {
                if (interactableObject.CanBeInteractedWith(player))
                {
                    MessageBox.Show("Interact succesfull");
                    LearningTime learningTime = new LearningTime(timerClass);
                    learningTime.Show();
                }
            }
        }
    }
}
