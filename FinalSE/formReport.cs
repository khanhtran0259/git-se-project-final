using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSE
{
    public partial class formReport : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn2"].ConnectionString);
        public formReport()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frmMain = new Mainform();
            this.Hide();
            frmMain.Show();
        }

        private void formReport_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> data = new Dictionary<int, string>();
            data.Add(0,"--Select--");
            data.Add(1,"Import");
            data.Add(2,"Export");
            comboBox1.DataSource = new BindingSource(data, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Import")
            {
                load_MainDGV("Import");
            }
            else if (comboBox1.Text == "Export")
            {
                load_MainDGV("Export");
            }
        }

        private void load_MainDGV(String type)
        {
            conn.Open();
            try
            {
                if (type.Equals("Import"))
                {
                    SqlCommand cmd = new SqlCommand("EXEC fill_ImportedMainDGV @month =" + txtMonth.Text.ToString() + ", @year =" + txtYear.Text.ToString(), conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (type.Equals("Export"))
                {
                    SqlCommand cmd = new SqlCommand("EXEC fill_ExportedMainDGV @month=" + txtMonth.Text.ToString() + ", @year =" + txtYear.Text.ToString(), conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String type = comboBox1.Text;
            conn.Open();
            try
            {
                if (type.Equals("Import"))
                {
                    int idx = dataGridView1.SelectedCells[0].RowIndex;
                    if (idx < 0 && idx >= dataGridView1.Rows.Count) { return; }
                    DataGridViewRow row = dataGridView1.Rows[idx];
                    SqlCommand cmd = new SqlCommand("EXEC fill_ImportedDataGridView @id ="+ row.Cells[0].Value.ToString(), conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                else if (type.Equals("Export"))
                {
                    int idx = dataGridView1.SelectedCells[0].RowIndex;
                    if (idx < 0 && idx >= dataGridView1.Rows.Count) { return; }
                    DataGridViewRow row = dataGridView1.Rows[idx];
                    String sSQL = "EXEC fill_ExportedSubDataGridView @id =" + row.Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

            }
            conn.Close();
        }
    }
}
