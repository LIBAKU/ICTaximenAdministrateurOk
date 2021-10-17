using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ICTaximen.Classes;

namespace ICTaximen.userControls
{
    public partial class ucAjouterUtilisateurForm : UserControl
    {
        public int IDMalade = -1;
        public TextBox Id
        {
            get { return txtid; }
            set { txtid = value; }
        }
        public TextBox Nom
        {
            get { return txtName; }
            set { txtName = value; }
        }
        public TextBox Username
            {
            get { return txtUname; }
            set { txtUname = value; }
            }
      
        public PictureEdit Photo
        {
            get{ return picPhoto; }
            set { picPhoto = value; }
        }
        public ucAjouterUtilisateurForm()
        {
            InitializeComponent();
            cmbNiveau.SelectedIndex = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
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

        private void ucAjouterUtilisateurForm_Load(object sender, EventArgs e)
        {
            
        }

        private void picPhoto_DoubleClick(object sender, EventArgs e)
        {
            clsPhoto img = new clsPhoto();
            img.ImageImport1(picPhoto);
        }

        void RefreshForm(String index = null)
        {
            
            txtid.Text = "";
            IDMalade = -1;
            txtName.Text = "";
            txtUname.Text = "";
            txtUserpassword.Text = "";
            txtComfirmpassword.Text = "";
            cmbNiveau.SelectedIndex=0;            
            //txtFonction.SelectedIndex = -1;
            picPhoto.Image = Properties.Resources.user_64;
            

        }
        //test de valeur null
        private Boolean CheckFormFields()
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtUname.Text.Trim())
                && !String.IsNullOrWhiteSpace(txtUserpassword.Text.Trim()) 
                && !String.IsNullOrWhiteSpace(txtComfirmpassword.Text.Trim())
                )
            {
                if (cmbNiveau.SelectedIndex != 0)
                {
                    if(txtComfirmpassword.Text == txtUserpassword.Text)
                    {
                        return true;
                    }
                }                  
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
                            txtName.Text,
                            int.Parse(cmbNiveau.Text),
                            txtUname.Text,
                            txtUserpassword.Text,                            
                            ALLProjetctdll.Classes.clsGlossiaire.GetInstance().getByteImage(picPhoto)
                        };


                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveUser", Constantes.UserDBChamps, values);
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
    }
}
