using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Kunskapsspel
{
    internal class Entity
    {
        protected Control control;

        protected Entity(Control control)
        {
            this.control = control;
        }

        public int LeftLocation => control.Location.X;
        public int RightLocation => control.Location.X + control.Width;
        public int TopLocation => control.Location.Y;
        public int BottomLocation => control.Location.Y + control.Height;

        public int X => control.Location.X;
        public int Y => control.Location.Y;

        public int Width => control.Width;
        public int Height => control.Height;

        public void Move(int x, int y)
        {
            control.Location.Offset(x, y);
        }
        public void SetPosition(int x, int y)
        {
            control.Location = new System.Drawing.Point(x,y);
        }
        public void SetPosition(Point point)
        {
            control.Location = point;
        }

        public virtual void OnUpdate()
        {

        }

    }
    internal class PictureEntity : Entity
    {
        public PictureBox PictureBox => (PictureBox)control;

        public PictureEntity(PictureBox pictureBox)
            :base(pictureBox)
        {
        
        }

        
    }
}
