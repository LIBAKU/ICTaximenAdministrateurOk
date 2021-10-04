using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICTaximen.Frms;

namespace ICTaximen.Classes
{
    class MainControlClass
    {
        public static void showControl(System.Windows.Forms.UserControl control, System.Windows.Forms.Control pnlContainner)
        {
            pnlContainner.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            pnlContainner.Controls.Add(control);

            



        }

        public static void returnControl(System.Windows.Forms.Control pnlContainner)
        {
           // pnlContainner.Controls.Clear();

            //control.Dock = DockStyle.Fill;
            //control.SendToBack();
            //control.Dispose();

           // pnlContainner.Controls.Add(control);

pnlContainner.Controls.Clear();
        }
    }
}
