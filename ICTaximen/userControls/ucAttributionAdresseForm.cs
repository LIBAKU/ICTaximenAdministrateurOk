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
    public partial class ucAttributionAdresseForm : UserControl
    {
        public int IDMalade = -1;
        object[] data;

        public ucAttributionAdresseForm(object[] data = null)
        {
            InitializeComponent();
            if (data != null) this.data = data;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdbAgent.Checked == true)
                {
                Save(0,"agentAdresse");

                }
                else if(rdbProprietaire.Checked == true)
                {
                Save(0,"proprietaireAdresse");

                }
                else if(rdbTaximan.Checked == true)
                {
                    Save(0, "taximanAdresse");
           
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        void RefreshForm(String index = null)
        {
            IDMalade = -1;
            cmbPersonne.Text = "";
            cmbAddresse.Text = "";
            txtid.Text = "";
            txtRef.Text = "";

            if(rdbAgent.Checked == true)
            {
                rdbAgent.Checked = false;
            }
            else if(rdbProprietaire.Checked == true)
            {
                rdbProprietaire.Checked = false;
            }
            else if(rdbTaximan.Checked == true)
            {
                rdbTaximan.Checked = false;
            }
        }
        private Boolean CheckFormFields()
        {
            if (!String.IsNullOrWhiteSpace(txtid.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtRef.Text.Trim()))
            {
                if(rdbAgent.Checked==true || rdbProprietaire.Checked==true || rdbTaximan.Checked == true)
                {
                    return true;
                }
                
            }
            return false;
        }
        private void Save(int index, string procedure)
        {
            if (index == 0)
            {
                if (this.CheckFormFields())
                {


                    object[] values = new object[]
                        {

                           int.Parse(txtid.Text),
                           int.Parse(txtRef.Text),                           
                           ""+ALLProjetctdll.Classes.UserSession.GetInstance().UserName
                        };


                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData(procedure, Constantes.AddressRefDBChamps, values);
                        this.RefreshForm();
                        // taximan.ChargerGrid();
                    }

                }
                else
                {
                    MessageBox.Show("Il y a des champs Requis", "INFOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (index == 1) { }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           
                if(!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucMyadresse"))
                {
                    ucMyadresse un = new ucMyadresse();
                    un.Dock = DockStyle.Fill;
                    frmHome.Instance.PnlContainer.Controls.Add(un);
                    frmHome.Instance.BackButton.Visible = true;
                }
                frmHome.Instance.PnlContainer.Controls["ucMyadresse"].BringToFront();
            
        }
        public void ChargeCombo(ComboBox cmb, string designation, string table)
        {

        try
        {
            ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().chargeCombo(cmb, designation, table);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

        private void cmbPersonne_MouseHover(object sender, EventArgs e)
        {
            if(rdbAgent.Checked == true)
            {
                cmbPersonne.Items.Clear();
                ChargeCombo(cmbPersonne, "Nom", "tagent");
            }
            else if (rdbProprietaire.Checked == true)
            {
                cmbPersonne.Items.Clear();
                ChargeCombo(cmbPersonne, "Nom", "tproprietaire");
            }
            else if (rdbTaximan.Checked == true)
            {
                cmbPersonne.Items.Clear();
                ChargeCombo(cmbPersonne, "Nom", "ttaximen");
            }            
        }

        private void cmbPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdbAgent.Checked == true)
            {
                txtid.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "tagent", "Nom", cmbPersonne.Text)).ToString();
            }
            else if(rdbProprietaire.Checked == true)
            {
                txtid.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "tproprietaire", "Nom", cmbPersonne.Text)).ToString();
            }
            else if(rdbTaximan.Checked == true)
            {
                txtid.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "ttaximen", "Nom", cmbPersonne.Text)).ToString();
            }
           
        }

        private void cmbAddresse_MouseHover(object sender, EventArgs e)
        {
            cmbAddresse.Items.Clear();
            ChargeCombo(cmbAddresse, "Numeromaison", "tadresse");
        }

        private void cmbAddresse_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRef.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "tadresse", "Numeromaison", cmbAddresse.Text)).ToString();
        }
    }
}