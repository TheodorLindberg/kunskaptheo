using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Kunskapsspel
{
    internal class MovementClass
    {
        private const int movementSpeed = 35;
        const Key forwardKey = Key.W;
        const Key leftKey = Key.A;
        const Key backwardsKey = Key.S;
        const Key rightKey = Key.D;
        public MovementClass() { }

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

        public void Move(PictureBox background, List<InteractableObject> interactableObjects, Player player)
        {
            (int x, int y) = GetOffset();
            (bool CanGoToX, bool CanGoToY) = CanMoveTo(background, x, y, player);
            
            if (CanGoToX)
            {
                foreach (InteractableObject pb in interactableObjects)
                    pb.itemBody.Location = new Point(pb.itemBody.Location.X + x, pb.itemBody.Location.Y);
                background.Location = new Point(background.Location.X + x, background.Location.Y);
            }

            if (CanGoToY)
            {
                foreach (InteractableObject pb in interactableObjects)
                    pb.itemBody.Location = new Point(pb.itemBody.Location.X, pb.itemBody.Location.Y + y);
                background.Location = new Point(background.Location.X, background.Location.Y + y);
            }
        }



        private Tuple<bool, bool> CanMoveTo(PictureBox floor, int x, int y, Player player)
        {
            bool CanGoToX = false;
            bool CanGoToY = false;

            if (floor.Location.X + x <= player.LeftLocation && floor.Location.X + floor.Width + x >= player.RightLocation)
                CanGoToX = true;
            if (floor.Location.Y + y <= player.BottomLocation && floor.Location.Y + floor.Height + y >= player.BottomLocation)
                CanGoToY = true;

            return Tuple.Create(CanGoToX, CanGoToY);
        }
    }
}
