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
    public partial class ucCategorieEngin : UserControl
    {
        public ucCategorieEngin()
        {
            InitializeComponent();
        }
        public int IDMalade = -1;
        object[] data;
        clsImabar codage = new clsImabar();

        void RefreshForm(String index = null)
        {
            IDMalade = -1;
            txtCategorie.Text = "";
            txtid.Text = "";
            ChargerGrid();
        }
        private Boolean CheckFormFields()
        {
            if (!String.IsNullOrWhiteSpace(txtCategorie.Text.Trim()))                
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
                           txtCategorie.Text,
                         
                        };


                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveCategorie", Constantes.PaysDBChamps, values);
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
            try{
                if (String.IsNullOrWhiteSpace(txtid.Text.Trim()))
                {

                    Save(0);
                }
                else
                {
                    IDMalade = int.Parse(txtid.Text);
                    Save(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void ucCategorieEngin_Load(object sender, EventArgs e)
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

                dgvEngin.DataSource = ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetTable("tcategorieengin");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvEngin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                txtid.Text = dgvEngin.CurrentRow.Cells["Id"].Value.ToString();
                // pers.Id.Text = dgvEngin.CurrentRow.Cells["Id"].Value.ToString();
                txtCategorie.Text = dgvEngin.CurrentRow.Cells["Designation"].Value.ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!", ex.Message);
            }

        }
    }
}
