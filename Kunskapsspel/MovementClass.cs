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
        GameForm form;
        const Key forwardKey = Key.W;
        const Key leftKey = Key.A;
        const Key backwardsKey = Key.S;
        const Key rightKey = Key.D;
        PictureBox backGround;
        public MovementClass(GameForm form)
        {
            this.form = form;
            
        }

        private Tuple<int, int> GetDestination()
        {
            backGround = form.tempPb;
            int x = backGround.Location.X;
            int y = backGround.Location.Y;

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
            backGround = form.tempPb;
            (int x, int y) = GetDestination();
            backGround.Location = new Point(x, y);
        }
    }
}
