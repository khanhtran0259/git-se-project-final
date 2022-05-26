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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnFormImort_Click(object sender, EventArgs e)
        {
            frmDgv1 form = new frmDgv1();
            form.Show();
            this.Hide();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            formExport form = new formExport();
            form.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            formReport form = new formReport();
            form.Show();
            this.Hide();
        }
    }
}
