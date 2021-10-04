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

namespace ICTaximen.userControls
{
    public partial class ucEnginForm : UserControl
    {
        public ucEnginForm()
        {
            InitializeComponent();
        }

        private void btnAffecter_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.PnlContainer.Controls.ContainsKey("ucAffectationConduit"))
            {
                ucAffectationConduit un = new ucAffectationConduit();
                un.Dock = DockStyle.Fill;
                frmHome.Instance.PnlContainer.Controls.Add(un);
                frmHome.Instance.BackButton.Visible = true;
            }
            frmHome.Instance.PnlContainer.Controls["ucAffectationConduit"].BringToFront();
        }
    }
}
