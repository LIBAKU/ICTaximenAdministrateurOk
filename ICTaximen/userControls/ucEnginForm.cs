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
using ICTaximen.Classes;
using System.IO;

namespace ICTaximen.userControls
{
    public partial class ucEnginForm : UserControl
    {
        public int IDMalade = -1;
        object[] data;
        clsImabar codage = new clsImabar();
        ucAffectationConduit conduit = new ucAffectationConduit();
        public ucEnginForm(object[] data = null)
        {
            InitializeComponent();
            if (data != null) this.data = data;
        }
        void RefreshForm(String index = null)
        {
             IDMalade = -1;
            txtMarque.Text = "";
            txtCouleur.Text = "";
            txtNumerochasis.Text = "";
            txtNumeromoteur.Text = "";
            cmbCatEngin.Text = "";
            txtCategorieEngin.Text = "";
            cmbProprietaire.Text = "";
            txtProprietaire.Text = "";
            pEQrcode.Image = Properties.Resources.icons8_QR_Code_64;
            ChargerGrid();
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
                           txtMarque.Text,
                           txtCouleur.Text,
                           txtNumerochasis.Text,
                           txtNumeromoteur.Text,
                           ALLProjetctdll.Classes.clsGlossiaire.GetInstance().getByteImage(pEQrcode),
                           txtProprietaire.Text,
                           txtCategorieEngin.Text,
                           ""+ALLProjetctdll.Classes.UserSession.GetInstance().UserName
                        };


                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveEngin", Constantes.EnginDBChamps, values);
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

        private Boolean CheckFormFields()
        {
            if (!String.IsNullOrWhiteSpace(txtMarque.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtCouleur.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtNumerochasis.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtNumeromoteur.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtCategorieEngin.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtProprietaire.Text.Trim()))
                {
                return true;
                }
            return false;
    } 
            private void btnAffecter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(conduit.Id.Text.Trim()))
            {
                MessageBox.Show("veillez selectionner un element dans le tableau", "INFOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAffectationConduit"))
                {
                   // ucAffectationConduit un = new ucAffectationConduit();
                    conduit.Dock = DockStyle.Fill;
                    frmHome.Instance.PnlContainer.Controls.Add(conduit);
                    frmHome.Instance.BackButton.Visible = true;
                }
                frmHome.Instance.PnlContainer.Controls["ucAffectationConduit"].BringToFront();
            }
            
        }
        public void ChargeCombo(ComboBox cmb,string designation,string table)
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

        private void cmbCatEngin_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void cmbProprietaire_MouseHover(object sender, EventArgs e)
        {
            cmbProprietaire.Items.Clear();
            ChargeCombo(cmbProprietaire, "Nom", "tproprietaire");
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
                    IDMalade = int.Parse(txtid.Text);                
                    codage.QRCode(pEQrcode, txtid.Text);
                    Save(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cmbProprietaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProprietaire.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "tproprietaire", "Nom", cmbProprietaire.Text)).ToString();
        }

        private void cmbCatEngin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCategorieEngin.Text = (ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetID("Id", "tcategorieengin", "Designation", cmbCatEngin.Text)).ToString();
        }

        private void dgvEngin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                Byte[] img1 = (Byte[])dgvEngin.CurrentRow.Cells["Qrcode"].Value;

                MemoryStream ms1 = new MemoryStream(img1);

                pEQrcode.Image = Image.FromStream(ms1);

                txtid.Text = dgvEngin.CurrentRow.Cells["Id"].Value.ToString();

                conduit.Id.Text = dgvEngin.CurrentRow.Cells["Id"].Value.ToString();
                conduit.MArque.Text = dgvEngin.CurrentRow.Cells["Marque"].Value.ToString();
                conduit.Couleur.Text = dgvEngin.CurrentRow.Cells["Couleur"].Value.ToString();
                conduit.NumeroChasis.Text = dgvEngin.CurrentRow.Cells["Numerochasis"].Value.ToString();
                conduit.NumeroMoteur.Text = dgvEngin.CurrentRow.Cells["Numeromoteur"].Value.ToString();

                txtMarque.Text = dgvEngin.CurrentRow.Cells["Marque"].Value.ToString();
                txtCouleur.Text = dgvEngin.CurrentRow.Cells["Couleur"].Value.ToString();
                txtNumerochasis.Text = dgvEngin.CurrentRow.Cells["Numerochasis"].Value.ToString();
                txtNumeromoteur.Text = dgvEngin.CurrentRow.Cells["Numeromoteur"].Value.ToString();
                txtProprietaire.Text = dgvEngin.CurrentRow.Cells["Refproprietaire"].Value.ToString();
                txtCategorieEngin.Text = dgvEngin.CurrentRow.Cells["Refcategorie"].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!", ex.Message);
            }
        }

        private void ucEnginForm_Load(object sender, EventArgs e)
        {
            ChargerGrid();
        }
        public void ChargerGrid()
        {

            try
            {
                dgvEngin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEngin.RowTemplate.Height = 30;
                dgvEngin.AllowUserToAddRows = false;


                dgvEngin.DataSource = ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetTable("tengin");

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbCatEngin_MouseHover(object sender, EventArgs e)
        {
            cmbCatEngin.Items.Clear();
            ChargeCombo(cmbCatEngin, "Designation", "tcategorieengin");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
