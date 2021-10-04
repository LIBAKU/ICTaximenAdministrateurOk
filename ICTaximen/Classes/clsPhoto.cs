using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICTaximen.Classes
{
    public class clsPhoto
    {
        public void ImageImport(PictureBox img)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "choose Image(*.JPG; *.PNG; *.GIF)|*.jpg; *.png; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
