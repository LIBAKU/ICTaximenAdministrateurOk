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
    public partial class ucAssociation : UserControl
    {
        int IDMalade = -1;
        public ucAssociation()
        {
            InitializeComponent();
        }
        void Refresh(String index = null)
        {

            txtlibelle.Text = "";
            
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
                            txtlibelle.Text,
                            ""+ALLProjetctdll.Classes.UserSession.GetInstance().UserName,
                        };

                    if (MessageBox.Show("Voulez-vous enregistrer?", "ENREGISTREMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ALLProjetctdll.Classes.clsGlossiaireMYSQL.GetInstance().saveData("saveAssociation", Constantes.AssociationDBChamps, values);
                        Refresh();


                    }
                    else
                    {
                        MessageBox.Show("Il y a des champs Requis", "INFOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (index == 1) { }
            }
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
    }
}
