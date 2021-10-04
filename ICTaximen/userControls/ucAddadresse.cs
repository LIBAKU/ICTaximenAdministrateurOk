using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICTaximen.userControls
{
    public partial class ucAddadresse : UserControl
    {
        public Label AddresseTitle
        {
            get { return lblTitle; }
            set { lblTitle = value; }
        }
        public Label ChooseRef
        {
            get { return lblChoose; }
            set { lblChoose = value; }
        }
        public Panel PnlChoose
        {
            get { return pnlChoose; }
            set { pnlChoose = value; }
        }
        public PictureBox PBLibelle
        {
            get { return pbLibelle; }
            set { pbLibelle = value; }
        }
        public PictureBox PBRef
        {
            get { return pbRef; }
            set { pbRef = value; }
        }
        public ucAddadresse()
        {
            InitializeComponent(); 
            pnlChoose.Visible = false;
            

        }

        private void pnlContainner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void ucAddadresse_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
