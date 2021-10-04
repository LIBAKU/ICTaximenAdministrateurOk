﻿using System;
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
            //MainControlClass.showControl(adad, pnlContainner);
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAddadresse"))
            {
                ucAddadresse un = new ucAddadresse();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
                un.AddresseTitle.Text = "Ville";
                un.PnlChoose.Visible = false;
                un.PBLibelle.Image = Properties.Resources.ville_32;
            }
            frmHome.Instance.PnlContainer.Controls["ucAddadresse"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;

        }

        private void btnCommune_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAddadresse"))
            {
                ucAddadresse un = new ucAddadresse();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
                un.AddresseTitle.Text = "Commune";
                un.ChooseRef.Text = "Choisir Ville";
                un.PnlChoose.Visible = true;
                un.PBLibelle.Image = Properties.Resources.commune_32;
                un.PBRef.Image = Properties.Resources.ville_32;
            }
            frmHome.Instance.PnlContainer.Controls["ucAddadresse"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

        private void btnQuartier_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAddadresse"))
            {
                ucAddadresse un = new ucAddadresse();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
                un.AddresseTitle.Text = "Quartier";
                un.ChooseRef.Text = "Choisir Commune";
                un.PnlChoose.Visible = true;
                un.PBLibelle.Image = Properties.Resources.quartier_32;
                un.PBRef.Image = Properties.Resources.commune_32;
            }
            frmHome.Instance.PnlContainer.Controls["ucAddadresse"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

        private void btnAvenue_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAddadresse"))
            {
                ucAddadresse un = new ucAddadresse();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
                un.AddresseTitle.Text = "Avenue";
                un.ChooseRef.Text = "Choisir Quartier";
                un.PnlChoose.Visible = true;
                un.PBLibelle.Image = Properties.Resources.avenue_32;
                un.PBRef.Image = Properties.Resources.quartier_32;

            }
            frmHome.Instance.PnlContainer.Controls["ucAddadresse"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }
    }
}