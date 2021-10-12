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
using DevExpress.XtraEditors;

namespace ICTaximen.userControls
{
    public partial class ucAgeantform : UserControl
    {
        public int IDMalade = -1;
        object[] data;
        clsImabar codage = new clsImabar();
        string sexe;
        string dateNaissance1;
        public TextBox Id
        {
            get { return txtid; }
            set { txtid = value; }
        }
        public TextBox Nom
        {
            get { return txtNom; }
            set { txtNom = value; }
        }
        public TextBox Postnom
        {
            get { return txtPostom; }
            set { txtPostom = value; }
        }
        public TextBox Prenom
        {
            get { return txtprenom; }
            set { txtprenom = value; }
        }
        public TextBox Telephone
        {
            get { return txtTelephone; }
            set { txtTelephone = value; }
        }
        public TextBox Email
        {
            get { return txtEmail; }
            set { txtEmail = value; }
        }
        public TextBox Numeronationnal
        {
            get { return txtNumeronational; }
            set { txtNumeronational = value; }
        }
        public TextBox Lieunaissance
        {
            get { return txtLieunaissance; }
            set { txtLieunaissance = value; }
        }
        public TextBox Username
        {
            get { return txtUsername; }
            set { txtUsername = value; }
        }
        public TextBox Password
        {
            get { return txtUserpassword; }
            set { txtUserpassword = value; }
        }
        public PictureEdit imgP
        {
            get { return picPhoto; }
            set { picPhoto = value; }
        }
        public PictureEdit qrcodeP
        {
            get { return pEQrcode; }
            set { pEQrcode = value; }
        }
        private void  getsexe()
        {
            if(rdbFeminin.Checked == true)
            {
                sexe = "Feminin";
            }
            else if (rdbMasculin.Checked == true)
            {
                sexe = "Masculin";
            }
           
        }
        private void getdate()
        {
            dateNaissance1 = dateNaissance.SelectionStart.Day.ToString() + "/" + dateNaissance.SelectionStart.Month.ToString() + "/" + dateNaissance.SelectionStart.Year.ToString();
        }
        public ucAgeantform(object[] data = null)
        {
            InitializeComponent();
            if (data != null) this.data = data;
        }
        //initialisation
        void RefreshForm(String index = null)
        {
            txtid.Text = "";
            IDMalade = -1;
            txtNom.Text = "";
            txtPostom.Text = "";
            txtprenom.Text = "";
            txtTelephone.Text = "";
            txtEmail.Text = "";
            txtLieunaissance.Text = "";
            txtUserpassword.Text = "";
            rdbFeminin.Checked = false;
            rdbMasculin.Checked = false;
            txtUsername.Text = "";
            txtNumeronational.Text = "";
            dateNaissance1 = "";
            //txtFonction.SelectedIndex = -1;
            picPhoto.Image = Properties.Resources.user_64;
            qrcodeP.Image = Properties.Resources.icons8_QR_Code_64;
            sexe = "";


        }
        //test de valeur null
        private Boolean CheckFormFields()
        {
            if (!String.IsNullOrWhiteSpace(txtNom.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtprenom.Text.Trim()) && !String.IsNullOrWhiteSpace(txtPostom.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtTelephone.Text.Trim()) && !String.IsNullOrWhiteSpace(txtUsername.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtEmail.Text.Trim()) && !String.IsNullOrWhiteSpace(txtUserpassword.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtNumeronational.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtLieunaissance.Text.Trim())
                )
            {
                return true;
            }
            return false;
        }
        //enregistrement
        private void Save(int index)
        {
            if (index == 0)
            {
                if (this.CheckFormFields())
                {


                    object[] values = new object[]
                        {

                           IDMalade,
                           txtNom.Text,
                           txtPostom.Text,
                           txtprenom.Text,
                           sexe,
                           txtNumeronational.Text,
                           txtLieunaissance.Text,
                           DateTime.Parse(dateNaissance1),
                           txtTelephone.Text,
                           txtEmail.Text,
                           ALLProjetctdll.Classes.clsGlossiaire.GetInstance().getByteImage(picPhoto),
                           ALLProjetctdll.Classes.clsGlossiaire.GetInstance().getByteImage(pEQrcode),
                           txtUsername.Text,
                           txtUserpassword.Text,
                           ""+ALLProjetctdll.Classes.UserSession.GetInstance().UserName
                        };


                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveAgent", Constantes.AgentDBChamps, values);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtid.Text.Trim()))
                {
                    getsexe();
                    getdate();
                    Save(0);
                }
                else
                {

                    getsexe();
                    getdate();
                    codage.QRCode(pEQrcode, txtid.Text);
                    Save(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void picPhoto_DoubleClick(object sender, EventArgs e)
        {
            clsPhoto img = new clsPhoto();
            img.ImageImport1(picPhoto);
        }
    }
}
