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
    internal class Resources
    {
        public Bitmap bitmapImage;
        public Resources(GameForm gameForm)
        {
            DownloadPictures(gameForm);

        }

        private void DownloadPictures(GameForm gameForm)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData("https://raw.githubusercontent.com/Marre24/Kunskapsspel/Picture-testing/Capybara.jpg");
            bitmapImage = new Bitmap(new MemoryStream(bytes));
        }
    }
}
