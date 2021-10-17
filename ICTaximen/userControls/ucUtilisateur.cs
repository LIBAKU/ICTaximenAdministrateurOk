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
using System.IO;

namespace ICTaximen.userControls
{
    public partial class ucUtilisateur : UserControl
    {
        ucAjouterUtilisateurForm pers = new ucAjouterUtilisateurForm();
        public ucUtilisateur()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAjouterUtilisateurForm"))
            {
                ucAjouterUtilisateurForm un = new ucAjouterUtilisateurForm();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
            }
            frmHome.Instance.PnlContainer.Controls["ucAjouterUtilisateurForm"].BringToFront();
            frmHome.Instance.BackButton.Visible = true;
        }

        public void ChargerGrid()
        {

            try
            {
                dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUser.RowTemplate.Height = 80;
                dgvUser.AllowUserToAddRows = false;


                dgvUser.DataSource = ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetTable("tusers");
              
                dgvUser.Columns["Userpassword"].Visible = false;
                dgvUser.Columns["Niveau"].Visible = false;

                ////datagrid_borrowers.Columns["middle_name"].Visible = false;
                //datagrid_borrowers.Columns["last_name"].Visible = false;
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                DataGridViewImageColumn imgCol1 = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dgvUser.Columns["Photo"];

                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom; imgCol1.ImageLayout = DataGridViewImageCellLayout.Zoom;

                //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(pers.Id.Text.Trim()))
            {
                MessageBox.Show("veillez selectionner un element dans le tableau", "INFOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().delete_Parametre("tusers", "Id", Int16.Parse(pers.Id.Text));
                ChargerGrid();
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Byte[] img = (Byte[])dgvUser.CurrentRow.Cells["Photo"].Value;

                MemoryStream ms = new MemoryStream(img);

                pers.Photo.Image = Image.FromStream(ms);


                //textBox1.Text = dgvPersonne.CurrentRow.Cells["Id"].Value.ToString();
                pers.Id.Text = dgvUser.CurrentRow.Cells["Id"].Value.ToString();
                pers.Nom.Text = dgvUser.CurrentRow.Cells["Nom"].Value.ToString();
                pers.Username.Text = dgvUser.CurrentRow.Cells["Username"].Value.ToString();
               // pers.Niveau.Text = dgvUser.CurrentRow.Cells["Niveau"].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!", ex.Message);
            }
        }

        private void ucUtilisateur_Load(object sender, EventArgs e)
        {
            ChargerGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(pers.Id.Text.Trim()))
            {
                MessageBox.Show("veillez selectionner un element dans le tableau", "INFOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAjouterUtilisateurForm"))
                {
                   // ucAjouterUtilisateurForm un = new ucAjouterUtilisateurForm();
                    pers.Dock = DockStyle.Fill;
                    frmHome.Instance.PnlContainer.Controls.Add(pers);
                }
                frmHome.Instance.PnlContainer.Controls["ucAjouterUtilisateurForm"].BringToFront();
                frmHome.Instance.BackButton.Visible = true;
                pers.IDMalade = int.Parse(pers.Id.Text.Trim());
            }
        }
    }
}
