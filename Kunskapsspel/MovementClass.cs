using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Kunskapsspel
{
    internal class MovementClass
    {
        private const int movementSpeed = 30;
        readonly GameForm form;
        readonly InteractableObject interactableObject;
        const Key forwardKey = Key.W;
        const Key leftKey = Key.A;
        const Key backwardsKey = Key.S;
        const Key rightKey = Key.D;
        public MovementClass(GameForm form)
        {
            this.form = form;
            interactableObject = new InteractableObject(new Point(0, 0), new Size(300, 200), form);
            form.interactableObject = interactableObject;
        }

        private Tuple<int, int> GetOffset()
        {
            int x = 0;
            int y = 0;

            if (Keyboard.IsKeyDown(forwardKey))
                y += movementSpeed;
            if (Keyboard.IsKeyDown(backwardsKey))
                y -= movementSpeed;
            if (Keyboard.IsKeyDown(leftKey))
                x += movementSpeed;
            if (Keyboard.IsKeyDown(rightKey))
                x -= movementSpeed;

            return Tuple.Create(x, y);
        }

        internal void Move()
        {
            (int x, int y) = GetOffset();


            interactableObject.itemBody.Location = new Point(interactableObject.itemBody.Location.X + x, interactableObject.itemBody.Location.Y + y);


            form.tempBackgroundPb.Location = new Point(form.tempBackgroundPb.Location.X + x, form.tempBackgroundPb.Location.Y + y);
        }
    }
}
