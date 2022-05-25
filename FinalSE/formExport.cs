using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSE
{
    public partial class formExport : Form
    {
        public formExport()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Mainform frm = new Mainform();
            frm.Show();
            this.Hide();
        }
    }
}
