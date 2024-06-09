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
    public partial class Form_Add : Form
    {
        string str_conn;
        SqlConnection conn;
        string query;
        SqlCommand cmd;
        public Form_Add()
        {
            InitializeComponent();
        }
        public void load_combobox_lop()
        {
            str_conn = @"Data Source=HASHIRAMA\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(str_conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            query = "SELECT MaLop FROM Lop";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                add_class_sinhvien.Items.Add(rdr["MaLop"].ToString());
            }
            conn.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_id_sinhvien.Clear();
            add_name_sinhvien.Clear();
            add_Nam.Checked = false;
            add_Nu.Checked = false;
            add_quequan_sinhvien.Clear();
            add_class_sinhvien.Text = "";
            add_id_sinhvien.Focus();
        }
        public bool check_infor()
        {
            if (add_id_sinhvien.Text == "")
            { return false; }
            else if (add_name_sinhvien.Text == "")
            { return false; }
            else if (add_Nam.Checked == false && add_Nu.Checked == false)
            { return false; }
            else if (add_quequan_sinhvien.Text == "")
            { return false; }
            else if (add_class_sinhvien.Text == "")
            { return false; }
            return true;
        }
        public bool check_id()
        {
            conn.Open();

            List<string> list = new List<string>();

            query = "Select MaSV from SinhVien";
            cmd = new SqlCommand(query, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(reader["MaSV"].ToString());
                }
            }
            foreach (string id in list)
            {
                if (id.Trim() == add_id_sinhvien.Text.Trim())
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    return false;
                }
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return true;
        }
    private void button1_Click(object sender, EventArgs e)
        {
            if (!check_infor())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!check_id())
            {
                MessageBox.Show("Mã sinh viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    byte gioitinh_temp;

                    // Assign 1 for Nam and 0 for Nu based on checkbox states
                    gioitinh_temp = add_Nam.Checked ? (byte)1 : (byte)0;


                    conn.Open();
                    query = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, QueQuan, MaLop) VALUES (@MaSV,@HoTen,@NgaySinh,@GioiTinh,@QueQuan,@MaLop);";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", add_id_sinhvien.Text);
                        cmd.Parameters.AddWithValue("@Hoten", add_name_sinhvien.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", add_birthday_sinhvien.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioitinh_temp); // Now stores byte value (1 or 0)
                        cmd.Parameters.AddWithValue("@QueQuan", add_quequan_sinhvien.Text);
                        cmd.Parameters.AddWithValue("@MaLop", add_class_sinhvien.Text);
                        //Console.WriteLine("Phong");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!", "Đã thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button2_Click(sender,e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                { conn.Close(); }
            }
        }

        private void Form_Add_Load(object sender, EventArgs e)
        {
            load_combobox_lop();
            try
            {
                str_conn = @"Data Source=HASHIRAMA\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Encrypt=False";
                conn = new SqlConnection(str_conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //if (conn.State == ConnectionState.Open)
                //{
                //    MessageBox.Show("Kết nối thành công!");
                //}
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
    }
}
