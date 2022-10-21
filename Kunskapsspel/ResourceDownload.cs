using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunskapsspel
{
    internal class ResourceDownload
    {
        public Bitmap bitmapImage;
        public ResourceDownload(GameForm gameForm)
        {
            DownloadPictures(gameForm);

        }

        private void DownloadPictures(GameForm gameForm)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData("https://raw.githubusercontent.com/Marre24/Kunskapsspel/Picture-testing/Capybara.jpg");
            bitmapImage = new Bitmap(new MemoryStream(bytes));

            PictureBox pictureBox = new PictureBox()
            {
                Image = bitmapImage,
                Size = new Size(200, 200),
                Location = new Point(500, 500),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            gameForm.Controls.Add(pictureBox);
            pictureBox.BringToFront();
        }
    }
}
