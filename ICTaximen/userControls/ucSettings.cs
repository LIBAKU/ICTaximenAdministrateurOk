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
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucUtilisateur"))
            {
                ucUtilisateur un = new ucUtilisateur();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucUtilisateur"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

        private void btnFonction_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucFonctionForm"))
            {
                ucFonctionForm un = new ucFonctionForm();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucFonctionForm"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

     
        private void btnParameter_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucParameters"))
            {
                ucParameters un = new ucParameters();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucParameters"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

        private void btnAssociation_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAdhesion"))
            {
                ucAdhesion un = new ucAdhesion();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucAdhesion"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }
        private void btnCategorieEngin_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucCategorieEngin"))
            {
                ucCategorieEngin un = new ucCategorieEngin();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucCategorieEngin"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        
    }

        private void btnAssoociation_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAssociation"))
            {
                ucAssociation un = new ucAssociation();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucAssociation"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

        private void btnAttribuer_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAttributionFonction"))
            {
                ucAttributionFonction un = new ucAttributionFonction();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucAttributionFonction"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucReport"))
            {
                ucReport un = new ucReport();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucReport"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }
    }
}
