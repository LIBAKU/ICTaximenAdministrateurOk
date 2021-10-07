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
using ICTaximen.Frms;

namespace ICTaximen.userControls
{
       
    public partial class ucAdresse : UserControl
    {


       
        clcTitle Tit = new clcTitle();
        //ucAddadresse adad = new ucAddadresse();

        public ucAdresse()
        {
            InitializeComponent();
        }

        private void btnVille_Click(object sender, EventArgs e)
        {
            ucAddadresse un = new ucAddadresse();
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAddadresse"))
            {
                
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
               
            }
            frmHome.Instance.PnlContainer.Controls["ucAddadresse"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
            un.AddresseTitle.Text = "Ville";
            un.ChooseRef.Text = "Choisir Province";
            un.PnlChoose.Visible = true;
            un.PBLibelle.Image = Properties.Resources.ville_32;
            un.PBRef.Image = Properties.Resources.Province_32;

        }

        private void btnCommune_Click(object sender, EventArgs e)
        {
            ucAddadresse un = new ucAddadresse();
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAddadresse"))
            {
               
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);              
                
            }
            frmHome.Instance.PnlContainer.Controls["ucAddadresse"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
            un.AddresseTitle.Text = "Commune";
            un.ChooseRef.Text = "Choisir Ville";
            un.PnlChoose.Visible = true;
            un.PBLibelle.Image = Properties.Resources.commune_32;
            un.PBRef.Image = Properties.Resources.ville_32;
        }

        private void btnQuartier_Click(object sender, EventArgs e)
        {
            ucAddadresse un = new ucAddadresse();
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAddadresse"))
            {
                
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
               
            }
            frmHome.Instance.PnlContainer.Controls["ucAddadresse"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
            un.AddresseTitle.Text = "Quartier";
            un.ChooseRef.Text = "Choisir Commune";
            un.PnlChoose.Visible = true;
            un.PBLibelle.Image = Properties.Resources.quartier_32;
            un.PBRef.Image = Properties.Resources.commune_32;
        }

        private void btnAvenue_Click(object sender, EventArgs e)
        {
            ucAddadresse un = new ucAddadresse();
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAddadresse"))
            {
                
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
               

            }
            frmHome.Instance.PnlContainer.Controls["ucAddadresse"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
            un.AddresseTitle.Text = "Avenue";
            un.ChooseRef.Text = "Choisir Quartier";
            un.PnlChoose.Visible = true;
            un.PBLibelle.Image = Properties.Resources.avenue_32;
            un.PBRef.Image = Properties.Resources.quartier_32;
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            ucAddadresse un = new ucAddadresse();
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAddadresse"))
            {
                
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
               
            }
            frmHome.Instance.PnlContainer.Controls["ucAddadresse"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
            un.AddresseTitle.Text = "Province";
            un.ChooseRef.Text = "Choisir Pays";
            un.PnlChoose.Visible = true;
            un.PBLibelle.Image = Properties.Resources.Province_32;
            un.PBRef.Image = Properties.Resources.Pays_32;
        }

        private void btnPays_Click(object sender, EventArgs e)
        {
            ucAddadresse un = new ucAddadresse();
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAddadresse"))
            {
                
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
                
               // un.PBRef.Image = Properties.Resources.Pays_32;
            }
            frmHome.Instance.PnlContainer.Controls["ucAddadresse"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
            un.AddresseTitle.Text = "Pays";
            un.PnlChoose.Visible = false;
            un.PBLibelle.Image = Properties.Resources.Pays_32;
        }

        private void btnAttribueradresse_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAttributionAdresseForm"))
            {
                ucAttributionAdresseForm un = new ucAttributionAdresseForm();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
              
            }
            frmHome.Instance.PnlContainer.Controls["ucAttributionAdresseForm"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }
    }
}
