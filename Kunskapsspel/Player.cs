using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Drawing.Drawing2D;
namespace Kunskapsspel
{
    public class Player
    {
        private GameForm gameForm;
        public PictureBox body;

        private Point playerPosition;


        Size bodySize = new Size(200,200);

        public int LeftLocation => body.Location.X;
        public int RightLocation => body.Location.X + body.Width;

        public int TopLocation => body.Location.Y;
        public int BottomLocation => body.Location.Y + body.Height;




        private const int movementSpeed = 35;
        const Key forwardKey = Key.W;
        const Key leftKey = Key.A;
        const Key backwardsKey = Key.S;
        const Key rightKey = Key.D;

        public Player(GameForm gameForm)
        {
            this.gameForm = gameForm;
            
            playerPosition = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - bodySize.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - bodySize.Height / 2);

            CreateBody();
        }

        private void CreateBody()
        {
            Image image = Image.FromFile(@"./Resources/amogus.png");
            
            body = new PictureBox()
            {
                Size = bodySize,
                Location = playerPosition,
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                
            };

            PointF[] points = { new PointF(10.0f, 10.0f), new PointF(500.0f, 10.0f), new PointF(500.0f, 500.0f) };  
            byte[] paths = { (byte)PathPointType.Start, (byte)PathPointType.Line, (byte)PathPointType.Line };

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath(points, paths);



            System.Drawing.Region region = new System.Drawing.Region(path);
            body.Region = region;
            gameForm.Controls.Add(body);
            body.Parent = gameForm;
            body.BringToFront();
        }


        public void Update()
        {

            Rectangle bounds = gameForm.background.Bounds;

            int dx = 0;
            int dy = 0;

            if (Keyboard.IsKeyDown(forwardKey))
                dy += movementSpeed;
            if (Keyboard.IsKeyDown(backwardsKey))
                dy -= movementSpeed;
            if (Keyboard.IsKeyDown(leftKey))
                dx += movementSpeed;
            if (Keyboard.IsKeyDown(rightKey))
                dx -= movementSpeed;



            Point center = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - bodySize.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - bodySize.Height / 2);

            Point newPlayer = new Point(-gameForm.background.Location.X - dx + center.X, -gameForm.background.Location.Y - dy + center.Y);



            //body.Location = new Point(-gameForm.background.Location.X - dx + center.X, -gameForm.background.Location.Y - dy + center.Y);

            gameForm.background.Location = new Point(gameForm.background.Location.X + dx, gameForm.background.Location.Y + dy);



            


            Console.WriteLine("Update: " + body.Location);

            

        }
    }
}
