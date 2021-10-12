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
    public partial class ucProprietaire : UserControl
    {
        public ucProprietaire()
        {
            InitializeComponent();
            frmHome.Instance.BackButton.Visible = true;
        }
        ucProprietaireForm pers = new ucProprietaireForm();

        //Fonction de chargament dans le data grid view
        public void ChargerGrid()
        {

            try
            {

                dgvPersonne.RowTemplate.Height = 80;
                dgvPersonne.AllowUserToAddRows = false;


                dgvPersonne.DataSource = ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetTable("tproprietaire");

                dgvPersonne.Columns["Userpassword"].Visible = false;
                dgvPersonne.Columns["Usersession"].Visible = false;
                dgvPersonne.Columns["Username"].Visible = false;
                dgvPersonne.Columns["Refadresse"].Visible = false;
                dgvPersonne.Columns["Qrcode"].Visible = false;

                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                DataGridViewImageColumn imgCol1 = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dgvPersonne.Columns["Photo"];
                imgCol1 = (DataGridViewImageColumn)dgvPersonne.Columns["Qrcode"];

                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom; imgCol1.ImageLayout = DataGridViewImageCellLayout.Zoom;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //te
       
        private void ucProprietaire_Load(object sender, EventArgs e)
        {
            ChargerGrid();
        }

        private void dgvPersonne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Byte[] img = (Byte[])dgvPersonne.CurrentRow.Cells["Photo"].Value;

                MemoryStream ms = new MemoryStream(img);

                pers.imgP.Image = Image.FromStream(ms);

                Byte[] img1 = (Byte[])dgvPersonne.CurrentRow.Cells["Qrcode"].Value;

                MemoryStream ms1 = new MemoryStream(img1);

                pers.qrcodeP.Image = Image.FromStream(ms1);

                //textBox1.Text = dgvPersonne.CurrentRow.Cells["Id"].Value.ToString();
                pers.Id.Text = dgvPersonne.CurrentRow.Cells["Id"].Value.ToString();
                pers.Nom.Text = dgvPersonne.CurrentRow.Cells["Nom"].Value.ToString();
                pers.Postnom.Text = dgvPersonne.CurrentRow.Cells["Postnom"].Value.ToString();
                pers.Prenom.Text = dgvPersonne.CurrentRow.Cells["Prenom"].Value.ToString();
                pers.Telephone.Text = dgvPersonne.CurrentRow.Cells["Telephone"].Value.ToString();
                pers.Email.Text = dgvPersonne.CurrentRow.Cells["Email"].Value.ToString();
                pers.Numeronationnal.Text = dgvPersonne.CurrentRow.Cells["Numeronational"].Value.ToString();
                pers.Lieunaissance.Text = dgvPersonne.CurrentRow.Cells["Lieunaissance"].Value.ToString();
                pers.Username.Text = dgvPersonne.CurrentRow.Cells["Username"].Value.ToString();
                pers.Password.Text = dgvPersonne.CurrentRow.Cells["Userpassword"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!", ex.Message);
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {

            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucProprietaireForm"))
            {
                ucProprietaireForm Uc = new ucProprietaireForm();
                Uc.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(Uc);

                frmHome.Instance.BackButton.Visible = true;
            }
            frmHome.Instance.PnlContainer.Controls["ucProprietaireForm"].BringToFront();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(pers.Id.Text.Trim()))
            {
                MessageBox.Show("veillez selectionner un element dans le tableau", "INFOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucProprietaireForm"))
                {

                    pers.Dock = DockStyle.Fill;
                    frmHome.Instance.PnlContainer.Controls.Add(pers);

                }
                frmHome.Instance.PnlContainer.Controls["ucProprietaireForm"].BringToFront();
                frmHome.Instance.BackButton.Visible = true;
                pers.IDMalade = int.Parse(pers.Id.Text.Trim());
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
                ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().delete_Parametre("tproprieraire", "Id", Int16.Parse(pers.Id.Text));
                ChargerGrid();
            }
        }
    }
}
