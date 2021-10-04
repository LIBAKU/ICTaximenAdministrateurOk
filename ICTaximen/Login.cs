using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using ICTaximen.Frms;

namespace ICTaximen
{
    public partial class Login : Form
    {
        WebClient wc = new WebClient();
        NameValueCollection dataTosend = new NameValueCollection();

        public Login()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUname_Click(object sender, EventArgs e)
        {
            txtUname.BackColor = Color.White;
            pnlUname.BackColor = Color.White;
            txtPwd.BackColor = Color.FromArgb(47, 51, 73);
            pnlPwd.BackColor = Color.FromArgb(47, 51, 73);
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            txtPwd.BackColor = Color.White;
            pnlPwd.BackColor = Color.White;
            txtUname.BackColor = Color.FromArgb(47, 51, 73);
            pnlUname.BackColor = Color.FromArgb(47, 51, 73);
        }

        private void icPwd_MouseDown(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = false;
        }

        private void icPwd_MouseUp(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (chbRememberme.Checked == true)
            {
                Properties.Settings.Default.UserName = txtUname.Text;
                Properties.Settings.Default.Password = txtPwd.Text;
                Properties.Settings.Default.Save();
            }
             if (chbRememberme.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

            this.Hide();
            frmHome form1 = new frmHome();
            form1.Closed += (s, args) => this.Close();
            form1.Show();


            //frmHome hm = new frmHome();            
            //hm.Show();
            
            


            //dataTosend["user_username"] = txtUname.Text;
            //dataTosend["user_password"] = txtPwd.Text;
            //string GetData = Encoding.UTF8.GetString(wc.UploadValues(@"http://localhost:8181/ICTaximen/index.php", dataTosend));

            //if (GetData == "nodata")
            //{
            //    MessageBox.Show("No data found", "#nodata");
            //}
            //else if (GetData == "dataerror")
            //{
            //    MessageBox.Show("something went be wrong", "#dataerror");
            //}
            //else if (GetData == "usernotfound")
            //{
            //    MessageBox.Show("user name not found", "#usernotfound");
            //}
            //else if (GetData == "userwrongpassword")
            //{
            //    MessageBox.Show("username/password incorrect", "#userwrongpassword");
            //}
            //else if (GetData == "userbanned")
            //{
            //    MessageBox.Show("your acount has been banned", "#userbanned");
            //}
            //else if (GetData == "success")
            //{
            //    MessageBox.Show("you're logged success");
            //}

        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                txtUname.Text = Properties.Settings.Default.UserName;
                txtPwd.Text = Properties.Settings.Default.Password;
                chbRememberme.Checked = true;
            }
        }
    }
}
