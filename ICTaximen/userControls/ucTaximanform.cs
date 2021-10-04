using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICTaximen.Classes;

namespace ICTaximen.userControls
{
    public partial class ucTaximanform : UserControl
    {
        public ucTaximanform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureTaximan_Click(object sender, EventArgs e)
        {
            clsPhoto img = new clsPhoto();
            img.ImageImport(pictureTaximan);
        }
    }
}
