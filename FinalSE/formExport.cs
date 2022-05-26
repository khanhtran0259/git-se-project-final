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
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn1"].ConnectionString);

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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadData()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Orders", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt); 
            dgrvList.DataSource = dt;
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
                int idx = dgrvList.SelectedCells[1].RowIndex;            
                DataGridViewRow row = dgrvList.Rows[idx];
                int iDNo = int.Parse(row.Cells[1].Value.ToString());

                SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProduct WHERE NOTEID = ID" + iDNo, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgrvDetail.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("NO Data!");
                }
                adapter.Dispose();
                dgrvDetail.Refresh();

            }
            catch (Exception)
            {

            }
        }
    }
}
