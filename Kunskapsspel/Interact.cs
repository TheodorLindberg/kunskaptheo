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

        public void Interact(InteractableObject interactableObject)
        {
            if (!Keyboard.IsKeyDown(Key.Space))
                return;

            if (interactableObject.CanBeInteractedWith())
            {
                Debug.WriteLine("ja");
            }
            else
            {
                Debug.WriteLine("nej");
            }
        }
    }
}
