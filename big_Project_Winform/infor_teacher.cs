using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace big_Project_Winform
{
    public partial class infor_teacher : Form
    {
        string query;
        string str_conn = @"Data Source=HASHIRAMA\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Encrypt=False";
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public infor_teacher()
        {
            InitializeComponent();
        }

        private void infor_teacher_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str_conn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                query = "SELECT * from GiangVien";
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if(dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("Mã giảng viên: "+ dataGridView1.Rows[i].Cells[0].Value.ToString() + "\n"+
                    "Tên giảng viên: " + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n"+
                    "Chuyên ngành giảng dạy: " + dataGridView1.Rows[i].Cells[2].Value.ToString() +"\n"
                    ,"Thông tin giảng viên",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
