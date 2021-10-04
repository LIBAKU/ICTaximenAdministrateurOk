﻿using System;
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
    public partial class ucUtilisateur : UserControl
    {
        public ucUtilisateur()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAjouterUtilisateurForm"))
            {
                ucAjouterUtilisateurForm un = new ucAjouterUtilisateurForm();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucAjouterUtilisateurForm"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }
    }
}
