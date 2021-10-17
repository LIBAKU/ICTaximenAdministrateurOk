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
    public partial class ucEnregistrement : UserControl
    {
        public ucEnregistrement()
        {
            InitializeComponent();
        }

        private void btnTaximan_Click(object sender, EventArgs e)
        {

            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucTaximan"))
            {
                ucTaximan un = new ucTaximan();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
                //un.AddresseTitle.Text = "Ville";
                //un.PnlChoose.Visible = false;
                //un.PBLibelle.Image = Properties.Resources.ville_32;
            }
            frmHome.Instance.PnlContainer.Controls["ucTaximan"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

        private void btnProprietaire_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucProprietaire"))
            {
                ucProprietaire un = new ucProprietaire();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
                //un.AddresseTitle.Text = "Ville";
                //un.PnlChoose.Visible = false;
                //un.PBLibelle.Image = Properties.Resources.ville_32;
            }
            frmHome.Instance.PnlContainer.Controls["ucProprietaire"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAgent"))
            {
                ucAgent un = new ucAgent();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
                //un.AddresseTitle.Text = "Ville";
                //un.PnlChoose.Visible = false;
                //un.PBLibelle.Image = Properties.Resources.ville_32;
            }
            frmHome.Instance.PnlContainer.Controls["ucAgent"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

        private void btnAttribuer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEngin_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucEnginForm"))
            {
                ucEnginForm un = new ucEnginForm();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucEnginForm"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }
    }
}
