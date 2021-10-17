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
    public partial class ucAttributionFonction : UserControl
    {
        
        clsImabar codage = new clsImabar();
        public ucAttributionFonction()
        {
            InitializeComponent();
        }
        void RefreshForm(String index = null)
        {
            txtAgent.Text = "";
            txtFoction.Text = "";
            cmbAgent.Text = "";
            cmbFonction.Text = "";
        }
        private Boolean CheckFormFields()
        {
            if (!String.IsNullOrWhiteSpace(txtAgent.Text.Trim()) && !String.IsNullOrWhiteSpace(txtAgent.Text.Trim())

                )
            {
                return true;
            }
            return false;
        }
        private void Save(int index)
        {
            if (index == 0)
            {
                if (this.CheckFormFields())
                {


                    object[] values = new object[]
                        {

                           int.Parse(txtAgent.Text),
                           int.Parse(txtFoction.Text),
                           ""+ALLProjetctdll.Classes.UserSession.GetInstance().UserName
                        };


                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("agentFoction", Constantes.AgentFonctionDBChamps, values);
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
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ChargeCombo(ComboBox cmb, string champ, string table)
        {

            try
            {
                ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().chargeCombo(cmb, champ, table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {              

                    Save(0);                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cmbAgent_MouseHover(object sender, EventArgs e)
        {
            cmbAgent.Items.Clear();
            ChargeCombo(cmbAgent,"Nom","tagent");
        }

        private void cmbFonction_MouseHover(object sender, EventArgs e)
        {
            cmbFonction.Items.Clear();
            ChargeCombo(cmbFonction,"Designation","tfonction");
        }

        private void cmbFonction_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFoction.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "tfonction", "Designation", cmbFonction.Text)).ToString();

        }

        private void cmbAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAgent.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "tagent", "Nom", cmbAgent.Text)).ToString();

        }
    }
}
