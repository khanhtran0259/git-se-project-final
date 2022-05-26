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
    public partial class frmDgv1 : Form
    {
        public int ImportID;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn2"].ConnectionString);
        Boolean CreatedBill = false;
        public frmDgv1()
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
            conn.Open();
            CreatedBill = true;
            permission();
            SqlCommand sqlCommand1 = new SqlCommand("SELECT GETDATE()", conn);
            DateTime date = new DateTime();
            date = (DateTime) sqlCommand1.ExecuteScalar();
            
            String sSQL = "EXEC new_receiptNote @date = '"+date+"'";
            SqlCommand sqlCommand = new SqlCommand(sSQL,conn);
            sqlCommand.ExecuteNonQuery(); 

            SqlCommand sqlCommand2 = new SqlCommand("SELECT MAX(id) as 'Max' FROM RECEIVENOTE", conn);
            ImportID = (int)sqlCommand2.ExecuteScalar();
            MessageBox.Show(ImportID.ToString());

            conn.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frmMain = new Mainform();
            this.Hide();
            frmMain.Show();
        }

        private void formImport_Load(object sender, EventArgs e)
        {
            permission();
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
            if (CreatedBill == true)
            {
                DataGridView_Load();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            int prdId = Int32.Parse(cbxProductName.SelectedValue.ToString());
            String sSQL = "EXEC add_ReceiveProduct @noteId = "+ImportID+", @productId = "+prdId+", @quantity = "+ txtQuantity.Text;
            SqlCommand sqlCommand = new SqlCommand(sSQL,conn);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duplicated product int ReceiveProduct");
            }
            DataGridView_Load();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.SelectedCells[0].RowIndex;
            if (idx < 0 && idx >= dataGridView1.Rows.Count)     { return; } 
            conn.Open();
            DataGridViewRow row = dataGridView1.Rows[idx];
            MessageBox.Show("Choosed ReceiveProduct id = " + row.Cells[0].Value.ToString());
                String sSQL = "EXEC remove_ReceiveProduct @noteId = " + ImportID + ", @productId = " + row.Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand(sSQL,conn);
                cmd.ExecuteScalar();
                DataGridView_Load();
            conn.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_Load()
        {
            SqlCommand cmd = new SqlCommand("EXEC fill_ImportedDataGridView @id = " + ImportID, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void permission()
        {
            if (CreatedBill == false)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnCreate.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnCreate.Enabled = false;
            }
        }
    }
}
