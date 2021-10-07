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
    public partial class ucFonctionForm : UserControl
    {
        int IDMalade = -1;

        public ucFonctionForm()        {
            
            InitializeComponent();
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
                            txtlibelle.Text
                            //""+ALLProjetctdll.Classes.UserSession.GetInstance().UserName,
                        };

                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                            ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveFonction", Constantes.PaysDBChamps, values);
                            Refresh();

                    }
                    else
                    {
                        MessageBox.Show("Il y a des champs Requis", "INFOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                }
                else if (index == 1) { }
            

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

       private void Refresh(String index = null)
        {
            txtlibelle.Text = "";
            ChargerGrid();
            
        }
        public void ChargerGrid()
        {

            try
            {
                dgvFonction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvFonction.AllowUserToAddRows = false;
                dgvFonction.DataSource = ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetTable("tfonction");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ucFonctionForm_Load(object sender, EventArgs e)
        {
            ChargerGrid();
        }
    }
}
