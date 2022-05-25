using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace FinalSE
{
    public partial class formImport : Form
    {
        public int ImportID;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn2"].ConnectionString);
        public formImport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String sSQL = "EXEC new_receiptNote @date = getDate() as 'Max'";
            SqlCommand sqlCommand = new SqlCommand(sSQL);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            SqlCommand cmd = new SqlCommand("SELECT MAX(id) FROM RECEIPTNOTE");
            ImportID = (int)cmd.ExecuteScalar();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frmMain = new Mainform();
            this.Hide();
            frmMain.Show();
        }

        private void formImport_Load(object sender, EventArgs e)
        {
            string sSQL;
            sSQL = "SELECT * FROM PRODUCT";
            SqlCommand sqlCommand = new SqlCommand(sSQL,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cbxProductName.DataSource = dt;
                cbxProductName.DisplayMember = "Name";
                cbxProductName.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("NONE DATA!");
            }
            adapter.Dispose();
        }

    }
}
