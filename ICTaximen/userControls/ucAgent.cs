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
    public partial class ucAgent : UserControl
    {
        public ucAgent()
        {
            InitializeComponent();
            frmHome.Instance.BackButton.Visible = true;
        }
        ucAgeantform pers = new ucAgeantform();
        public void ChargerGrid()
        {

            try
            {
                // dgvPersonne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPersonne.RowTemplate.Height = 80;
                dgvPersonne.AllowUserToAddRows = false;


                dgvPersonne.DataSource = ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().GetTable("tagent");
                //dgvPersonne.Rows[n].Cells[2].Value = item["first_name"].ToString() + item["middle_name"].ToString() + item["last_name"].ToString();
                //dgvPersonne.Columns["Nom"].Visible = false;
                //dgvPersonne.Rows[1].Cells["Nom"].Value =  ToString(); 
                dgvPersonne.Columns["Userpassword"].Visible = false;
                dgvPersonne.Columns["Usersession"].Visible = false;
                dgvPersonne.Columns["Username"].Visible = false;
                dgvPersonne.Columns["Refadresse"].Visible = false;
                dgvPersonne.Columns["Qrcode"].Visible = false;
                dgvPersonne.Columns["Reffonction"].Visible = false;
                ////datagrid_borrowers.Columns["middle_name"].Visible = false;
                //datagrid_borrowers.Columns["last_name"].Visible = false;
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                DataGridViewImageColumn imgCol1 = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dgvPersonne.Columns["Photo"];
                imgCol1 = (DataGridViewImageColumn)dgvPersonne.Columns["Qrcode"];

                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom; imgCol1.ImageLayout = DataGridViewImageCellLayout.Zoom;

                //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnNew_Click_1(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAgeantform"))
            {
                ucAgeantform uC = new ucAgeantform();
                uC.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(uC);
                //un.AddresseTitle.Text = "Ville";
                //un.PnlChoose.Visible = false;
                //un.PBLibelle.Image = Properties.Resources.ville_32;
                frmHome.Instance.BackButton.Visible = true;
            }
            frmHome.Instance.PnlContainer.Controls["ucAgeantform"].BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(pers.Id.Text.Trim()))
            {
                MessageBox.Show("veillez selectionner un element dans le tableau", "INFOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().delete_Parametre("tagent", "Id", Int16.Parse(pers.Id.Text));
                ChargerGrid();
            }
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

        private void ucAgent_Load(object sender, EventArgs e)
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
                if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAgeantform"))
                {

                    pers.Dock = DockStyle.Fill;
                    frmHome.Instance.PnlContainer.Controls.Add(pers);

                }
                frmHome.Instance.PnlContainer.Controls["ucAgeantform"].BringToFront();
                frmHome.Instance.BackButton.Visible = true;
                pers.IDMalade = int.Parse(pers.Id.Text.Trim());
            }
        }
    }
}
