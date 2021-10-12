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
    public partial class ucAffectationConduit : UserControl
    {
        public int IDMalade = -1;
        clsImabar codage = new clsImabar();
        public ucAffectationConduit()
        {
            InitializeComponent();
        }
        public Label Id
        {
            get { return txtIdmoto; }
            set { txtIdmoto = value; }
        }
        public Label Couleur
        {
            get { return txtCouleur; }
            set { txtCouleur = value; }
        }
        public Label MArque
        {
            get { return txtMarque; }
            set { txtMarque = value; }
        }
        public Label NumeroChasis
        {
            get { return txtNumchasis; }
            set { txtNumchasis = value; }
        }
        public Label NumeroMoteur
        {
            get { return txtNummoteur; }
            set { txtNummoteur = value; }

        }

        void RefreshForm(String index = null)
        {
            txtIdmoto.Text = "";
            txtid.Text = "";
            IDMalade = -1;
            txtMarque.Text = "";
            txtCouleur.Text = "";
            txtNumchasis.Text = "";
            txtNummoteur.Text = "";
            txtTaximan.Text = "";
            cmbTaximan.Text = "";
        }

        private Boolean CheckFormFields()
        {
            if (!String.IsNullOrWhiteSpace(txtTaximan.Text.Trim())
              
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

                           IDMalade,                                                  
                           txtIdmoto.Text,
                           txtTaximan.Text,  
                            DateTime.Now,                          
                           ""+ALLProjetctdll.Classes.UserSession.GetInstance().UserName
                        };


                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveAffectation", Constantes.AffectationDBChamps, values);
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

        private void cmbTaximan_MouseHover(object sender, EventArgs e)
        {
            cmbTaximan.Items.Clear();
            ChargeCombo(cmbTaximan);
        }

        private void cmbTaximan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTaximan.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "ttaximen", "Nom", cmbTaximan.Text)).ToString();
        }

        public void ChargeCombo(ComboBox cmb)
        {

            try
            {
                ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().chargeCombo(cmb, "Nom", "ttaximen");
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
                if (String.IsNullOrWhiteSpace(txtid.Text.Trim()))
                {
                   
                    Save(0);
                }
                else
                {
                    IDMalade =int.Parse(txtid.Text);
                    Save(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            txtid.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "taffectationconduite", "Refengin", txtIdmoto.Text)).ToString();
        }

        private void pnlContainner_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
