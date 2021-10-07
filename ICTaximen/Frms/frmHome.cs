using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ICTaximen.Classes;
using ICTaximen.userControls;


namespace ICTaximen.Frms
{
    public partial class frmHome : Form
    {
        static frmHome _obj;
        public static frmHome Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmHome();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return pnlContainner; }
            set { pnlContainner = value; }
        }

        public Button BackButton
        {
            get { return btnReturn; }
            set { btnReturn = value; }
        }

        public Label NavTitle
        {
            get { return lblTitle; }
            set { lblTitle = value; }
        }

        
        private bool mouseDown;
        private Point lastLocation;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nWeightEllipse

            );

        ucDashboard dashboard = new ucDashboard();
        ucAdresse addresse = new ucAdresse();
        ucSettings settigs = new ucSettings();
        ucTaximanform register = new ucTaximanform();
        ucEnregistrement registerhome = new ucEnregistrement();
        ucContactus contact = new ucContactus();

        clcTitle Tit = new clcTitle();


        public frmHome()
        {
            InitializeComponent();
          //  Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
           
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblUname.Text = ALLProjetctdll.Classes.UserSession.GetInstance().UserName;
            //MainControlClass.showControl(dsb, pnlContainner);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            btnReturn.Visible = false;
            _obj = this;

            ucDashboard uc = new ucDashboard();
            uc.Dock = DockStyle.Fill;
            pnlContainner.Controls.Add(uc);
            lblTitle.Text = Tit.DashBord;
        }

        private void btnAdresse_Click(object sender, EventArgs e)
        {
            // MainControlClass.showControl(add, pnlContainner);

            pnlContainner.Controls.Clear();
            
            addresse.Dock = DockStyle.Fill;
            pnlContainner.Controls.Add(addresse);
            pnlContainner.Controls["ucAdresse"].BringToFront();
            lblTitle.Text = Tit.Address;



            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            pnlNav.Height = btnAdresse.Height;
            pnlNav.Top = btnAdresse.Top;
            btnAdresse.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //MainControlClass.showControl(dsb, pnlContainner);
            dashboard.Dock = DockStyle.Fill;
            pnlContainner.Controls.Add(dashboard);
            pnlContainner.Controls["ucDashboard"].BringToFront();
            lblTitle.Text = Tit.DashBord;

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnEnregistrement_Click(object sender, EventArgs e)
        {
            // MainControlClass.showControl(reg, pnlContainner);
            registerhome.Dock = DockStyle.Fill;
            pnlContainner.Controls.Add(registerhome);
            pnlContainner.Controls["ucEnregistrement"].BringToFront();
            lblTitle.Text = Tit.Enregistrement;

            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            pnlNav.Height = btnEnregistrement.Height;
            pnlNav.Top = btnEnregistrement.Top;
            btnEnregistrement.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettigs_Click(object sender, EventArgs e)
        {
            //MainControlClass.showControl(sett, pnlContainner);
            settigs.Dock = DockStyle.Fill;
            pnlContainner.Controls.Add(settigs);
            pnlContainner.Controls["ucSettings"].BringToFront();
            lblTitle.Text = Tit.Settings;

            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            pnlNav.Height = btnSettigs.Height;
            pnlNav.Top = btnSettigs.Top;
            btnSettigs.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContactus_Click(object sender, EventArgs e)
        {
            contact.Dock = DockStyle.Fill;
            pnlContainner.Controls.Add(contact);
            pnlContainner.Controls["ucContactus"].BringToFront();
            lblTitle.Text = Tit.Contactus;

            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            pnlNav.Height = btnContactus.Height;
            pnlNav.Top = btnContactus.Top;
            btnContactus.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
        btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
                 
        }

        private void btnAdresse_Leave(object sender, EventArgs e)
        {
            btnAdresse.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEnregistrement_Leave(object sender, EventArgs e)
        {
            btnEnregistrement.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactus_Leave(object sender, EventArgs e)
        {
            btnContactus.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettigs_Leave(object sender, EventArgs e)
        {
            btnSettigs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //MainControlClass.returnControl(pnlContainner);
            //pnlContainner.Controls["ucDashboard"].BringToFront();
            pnlContainner.Controls.RemoveAt(0);
            btnReturn.Visible = false;
            

        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            
            //btnMaxi.Image = Minimize_Window_16.png;
           
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaxi.Image = Properties.Resources.Minimize_Window_16;
                
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaxi.Image = Properties.Resources.Maximize_Window_16;
            }
        }

     

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlTop_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaxi.Image = Properties.Resources.Minimize_Window_16;

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaxi.Image = Properties.Resources.Maximize_Window_16;
            }
        }

        public string MyTitle
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
               // lblTitle.Text;
            }
        }
    }   

}
