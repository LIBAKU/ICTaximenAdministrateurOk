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
    public partial class ucAgeantform : UserControl
    {
        public ucAgeantform()
        {
            InitializeComponent();
        }

        private void picturePersonne_Click(object sender, EventArgs e)
        {
            clsPhoto img = new clsPhoto();
            img.ImageImport(pictureAgent);
        }

        private void pictureAgent_Click(object sender, EventArgs e)
        {
            clsPhoto img = new clsPhoto();
            img.ImageImport(pictureAgent);
        }
    }
}
