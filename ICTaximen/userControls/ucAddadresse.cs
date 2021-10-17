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
    public partial class ucAddadresse : UserControl
    {
        int IDMalade = -1;
        object[] data;
        void Refresh(String index = null)
        {

            txtlibelle.Text = "";
            cmbChoose.Text = "";
           
        }
        public Label AddresseTitle
        {
            get { return lblTitle; }
            set { lblTitle = value; }
        }
        public Label ChooseRef
        {
            get { return lblChoose; }
            set { lblChoose = value; }
        }
        public Panel PnlChoose
        {
            get { return pnlChoose; }
            set { pnlChoose = value; }
        }
        public PictureBox PBLibelle
        {
            get { return pbLibelle; }
            set { pbLibelle = value; }
        }
        public PictureBox PBRef
        {
            get { return pbRef; }
            set { pbRef = value; }
        }
        public ucAddadresse()
        {
            InitializeComponent(); 
            pnlChoose.Visible = false;
            

        }

        private void pnlContainner_Paint(object sender, PaintEventArgs e)
        {

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

        private void ucAddadresse_Load(object sender, EventArgs e)
        {
            
            
        }

        private Boolean CheckMaladeFields()
        {
            if (!String.IsNullOrWhiteSpace(txtlibelle.Text.Trim()))
            {
                return true;
            }
            return false;
        }

        private void Save(int index)
        {
            if (index == 0)
            {
                if (this.CheckMaladeFields())
                {


                    object[] values = new object[]
                        {
                            IDMalade,
                            txtlibelle.Text,
                            lblId.Text
                            //""+ALLProjetctdll.Classes.UserSession.GetInstance().UserName,
                        };

                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (lblTitle.Text == "Pays")
                        { 
                            ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("savePays", Constantes.PaysDBChamps, values);
                            Refresh();

                        }
                        else if(lblTitle.Text == "Province")
                        {
                            ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveProvince", Constantes.AutreAdresseDBChamps, values);
                            Refresh();
                        }
                        else if (lblTitle.Text == "Ville")
                        {
                            ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveVille", Constantes.AutreAdresseDBChamps, values);
                            Refresh();
                        }
                        else if (lblTitle.Text == "Commune")
                        {
                            ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveCommune", Constantes.AutreAdresseDBChamps, values);
                            Refresh();
                        }
                        else if (lblTitle.Text == "Quartier")
                        {
                            ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveQuartier", Constantes.AutreAdresseDBChamps, values);
                            Refresh();
                        }
                        else if (lblTitle.Text == "Avenue")
                        {
                            ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveAvenue", Constantes.AutreAdresseDBChamps, values);
                            Refresh();
                        }


                    }

                }
                else
                {
                    MessageBox.Show("Il y a des champs Requis", "INFOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (index == 1) { }
            
        }

        public void ChargeCombo(string table)
        {

            try
            {
                ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().chargeCombo(cmbChoose,"Designation",table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void cmbChoose_MouseHover(object sender, EventArgs e)
        {
            cmbChoose.Items.Clear();
            
             if (lblTitle.Text == "Province")
            {
                ChargeCombo("tpays");
            }
            else if (lblTitle.Text == "Ville")
            {
                ChargeCombo("tprovince");
            }
            else if (lblTitle.Text == "Commune")
            {
                ChargeCombo("tville");
            }
            else if (lblTitle.Text == "Quartier")
            {
                ChargeCombo("tcommune");
            }
            else if (lblTitle.Text == "Avenue")
            {
                ChargeCombo("tquartier");
            }
        }

        private void cmbChoose_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lblTitle.Text=="Ville")
            {
                GetId("tprovince");
            }
            else if(lblTitle.Text == "Province")
            {
                GetId("tpays");
            }
            else if (lblTitle.Text == "Commune")
            {
                GetId("tville");
            }
            else if (lblTitle.Text == "Quartier")
            {
                GetId("tcommune");
            }
            else if (lblTitle.Text == "Avenue")
            {
                GetId("tquartier");
            }
        }

        private void GetId(string table)
        {
            try
            {
                lblId.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", table, "Designation", cmbChoose.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
