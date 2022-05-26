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
    public partial class formExport : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn2"].ConnectionString);

        public formExport()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           Form frmMain = new Mainform();
            this.Hide();
            frmMain.Show();
        }

        private void formExport_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridView1.SelectedCells[0].RowIndex;
            if (idx < 0 && idx >= dataGridView1.Rows.Count) { return; }
            conn.Open();
            DataGridViewRow row = dataGridView1.Rows[idx];
            MessageBox.Show("Choosed Orders id = " + row.Cells[0].Value.ToString());
            String sSQL = "EXEC fill_ExportedSubDataGridView @id =" + row.Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void LoadData()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("EXEC fill_ExportedMainDataGridView", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
        }

        private void dgrvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void updateData(DataGridViewCellEventArgs e)
        {
            try
            {
                

               

            }
            catch (Exception)
            {

            }
        }
    }
}
