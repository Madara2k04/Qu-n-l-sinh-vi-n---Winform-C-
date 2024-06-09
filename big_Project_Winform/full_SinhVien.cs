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
    public partial class full_SinhVien : Form
    {
        string str_conn;
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dt;
        string query;
        public full_SinhVien()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int GioiTinhColIndex = dataGridView1.Columns["GioiTinh"].Index;
            if (e.ColumnIndex == GioiTinhColIndex)
            {
                if (e.Value != null)
                {
                    bool isNam = (bool)e.Value;
                    e.Value = isNam ? "Nam" : "Nữ";
                }
            }
        }

        private void full_SinhVien_Load(object sender, EventArgs e)
        {
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);
            try
            {
                str_conn = @"Data Source=HASHIRAMA\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Encrypt=False";
                conn = new SqlConnection(str_conn);
                conn.Open();
                dt = new DataTable();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //if (conn.State == ConnectionState.Open)
                //{
                //    MessageBox.Show("Kết nối thành công!");
                //}
                query = "Select * from SinhVien";
                adapter = new SqlDataAdapter(query,conn);
                adapter.Fill(dt);
                dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                MessageBox.Show("Mã sinh viên: "+ dataGridView1.Rows[i].Cells[0].Value.ToString() + "\n"+
                    "Tên sinh viên: " + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n" +
                    "Ngày sinh: " + dataGridView1.Rows[i].Cells[2].Value.ToString() + "\n" +
                    "Giới tính: " + dataGridView1.Rows[i].Cells[3].Value.ToString() + "\n" +
                    "Quê quán: " + dataGridView1.Rows[i].Cells[4].Value.ToString() + "\n" +
                    "Lớp: "+ dataGridView1.Rows[i].Cells[5].Value.ToString(), "Thông tin sinh viên",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
