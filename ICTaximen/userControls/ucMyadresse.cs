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
    public partial class ucMyadresse : UserControl
    {
        public int IDMalade = -1;
        object[] data;

        public ucMyadresse(object[] data = null)
        {
            InitializeComponent();
            if (data != null) this.data = data;
        }
        void RefreshForm(String index = null)
        {
            IDMalade = -1;
            txtNumeromaison.Text = "";
            cmbChoose.Text = "";
            lblId.Text = "";
        }

        private Boolean CheckFormFields()
        {
            if (!String.IsNullOrWhiteSpace(txtNumeromaison.Text.Trim())
                && !String.IsNullOrWhiteSpace(lblId.Text.Trim())
                && !String.IsNullOrWhiteSpace(cmbChoose.Text.Trim()))
                
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

                           IDMalade,
                           txtNumeromaison.Text,
                           int.Parse(lblId.Text),                           
                           ""+ALLProjetctdll.Classes.UserSession.GetInstance().UserName
                        };


                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveAdresse", Constantes.MyAddressRefDBChamps, values);
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

        public void ChargeCombo(ComboBox cmb)
        {

            try
            {
                ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().chargeCombo(cmb, "Designation", "tavenue");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ucMyadresse_Load(object sender, EventArgs e)
        {
           // cmbChoose.Items.Clear();
            ChargeCombo(cmbChoose);
        }

        private void cmbChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblId.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "tavenue", "Designation", cmbChoose.Text)).ToString();
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
    }
}



   
   

    

   
    
   

    