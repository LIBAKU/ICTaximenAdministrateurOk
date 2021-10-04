using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICTaximen.Frms;

namespace ICTaximen.userControls
{
    public partial class ucTaximan : UserControl
    {
        public ucTaximan()
        {
            InitializeComponent();
            frmHome.Instance.BackButton.Visible = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucTaximanform"))
            {
                ucTaximanform un = new ucTaximanform();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
                //un.AddresseTitle.Text = "Ville";
                //un.PnlChoose.Visible = false;
                //un.PBLibelle.Image = Properties.Resources.ville_32;
                frmHome.Instance.BackButton.Visible = true;
            }
            frmHome.Instance.PnlContainer.Controls["ucTaximanform"].BringToFront();
           
        }
    }
}
