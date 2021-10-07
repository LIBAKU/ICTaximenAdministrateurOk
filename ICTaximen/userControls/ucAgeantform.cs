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
        string sexe;
       private void  getsexe()
        {
            if(rdbFeminin.Checked == true)
            {
                sexe = "Feminin";
            }
            else if (rdbMasculin.Checked == true)
            {
                sexe = "Masculin";
            }
           
        }
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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
