﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel
{
    public class InteractableObject
    {
        public PictureBox itemBody;
        private readonly GameForm form;
        public bool isCurrentlyInUse = false;

        public int LeftX
        {
            get
            {
                return itemBody.Location.X;
            }
            set { }
        }
        public int RightX
        {
            get
            {
                return itemBody.Location.X + itemBody.Width;
            }
            set { }
        }
        public int Top
        {
            get
            {
                return itemBody.Location.Y;
            }
            set { }
        }
        public int Bot => itemBody.Location.Y + itemBody.Height;

        public InteractableObject(Point ItemTopLeftPoint, Size ItemSize, Image image, GameForm form)
        {
            this.form = form;
            CreateBody(ItemTopLeftPoint, ItemSize, image);
        }

        public void CreateBody(Point ItemTopLeftPoint, Size ItemSize, Image image)
        {
            itemBody = new PictureBox()
            {
                Location = ItemTopLeftPoint,
                Size = ItemSize,
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Parent=form.background,
            };
            form.Controls.Add(itemBody);
        }

        public bool CanBeInteractedWith(Player player)                              // Change
        {
            if ((PointInbetween(LeftX, RightX, player.LeftLocation) || PointInbetween(LeftX, RightX, player.RightLocation)) && PointInbetween(Bot, Top, player.TopLocation))
                return true;
            
            return false;
        }
        private int highPoint = 0;
        private int lowPoint = 0;
        private bool PointInbetween(int pointA, int pointB, int comparePoint)
        {
            if (pointA == pointB)
            {
                MessageBox.Show("Error");
                return false;
            }

            if (pointA > pointB)
            {
                highPoint = pointA;
                lowPoint = pointB;
            }
            else
            {
                highPoint = pointB;
                lowPoint = pointA;
            }

            if (lowPoint <= comparePoint && highPoint >= comparePoint)
                return true;

            return false;
        }
    }
}
