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
    public partial class ucAdhesion : UserControl
    {
        int idMalade = -1;
        DateTime date;
        public ucAdhesion()
        {
            InitializeComponent();
        }

        private void cmbTaximen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTaximan.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "ttaximen", "Nom", cmbTaximen.Text)).ToString();
        }

        private void cmbAssociation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAssociation.Text= (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "tassociation", "Designation", cmbAssociation.Text)).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                date = DateTime.Now;
                if (!String.IsNullOrWhiteSpace(txtId.Text.Trim()))
                {
                    idMalade = int.Parse(txtId.Text);
                    Save(0);
                }
                else
                {
                    Save(0);
                }
                   

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        //
        void RefreshForm(String index = null)
        {
            idMalade = -1;
            txtId.Text = "";
            txtAssociation.Text = "";
            txtTaximan.Text = "";
            cmbTaximen.Text="";
            cmbAssociation.Text="";
        }
        private Boolean CheckFormFields()
        {
            if (!String.IsNullOrWhiteSpace(txtTaximan.Text.Trim()) && !String.IsNullOrWhiteSpace(txtAssociation.Text.Trim())

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
                           idMalade,
                           int.Parse(txtAssociation.Text),
                           int.Parse(txtTaximan.Text),
                           date,
                           ""+ALLProjetctdll.Classes.UserSession.GetInstance().UserName
                        };


                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveAdhesion", Constantes.AdhesionDBChamps, values);
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

        private void ucAdhesion_Load(object sender, EventArgs e)
        {
            ChargeCombo(cmbAssociation, "Designation", "tassociation");
            ChargeCombo(cmbTaximen, "Nom", "ttaximen");
        }

        private void txtTaximan_TextChanged(object sender, EventArgs e)
        {
            txtId.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "tadhesion", "Reftaximan", txtTaximan.Text)).ToString();
        }
    }
}
