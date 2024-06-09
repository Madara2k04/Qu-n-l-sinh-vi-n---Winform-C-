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
    public partial class form_sua : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string query;
        string gioitinh;
        string str_conn;
        public form_sua()
        {
            InitializeComponent();
        }
        public void enable_infor()
        {
            name.Enabled = true;
            date.Enabled = true;
            nam.Enabled = true;
            Nu.Enabled = true;
            quequan.Enabled = true;
            lop.Enabled = true;
            update.Enabled = true;
        }
        public void disable_infor()
        {
            name.Enabled = false;
            date.Enabled = false;
            nam.Enabled = false;
            Nu.Checked = false;
            quequan.Enabled = false;
            lop.Enabled = false;
            update.Enabled = false;

            lop.Text = string.Empty;
            quequan.Text = "";
            sua.Text = "";
            name.Clear();
            
            this.ActiveControl = sua;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                lop.Items.Add(rdr["MaLop"].ToString());
            }
            conn.Close();
        }
        private void form_sua_Load(object sender, EventArgs e)
        {
            str_conn = @"Data Source=HASHIRAMA\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(str_conn);
            conn.Open();
            load_combobox_lop();
            this.ActiveControl = sua;
            conn.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM SinhVien WHERE MaSV = @MaSV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", sua.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                if (Convert.ToBoolean(reader["GioiTinh"]))
                                {
                                    gioitinh = "Nam";
                                    nam.Checked = true;
                                }
                                else
                                {
                                    gioitinh = "Nữ";
                                    Nu.Checked = true;
                                }

                                enable_infor();
                                name.Text = reader["HoTen"].ToString();
                                date.Text = reader["NgaySinh"].ToString();
                                quequan.Text = reader["QueQuan"].ToString();
                                lop.Text = reader["MaLop"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên với mã số này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                byte gioitinh_temp;

                gioitinh_temp = nam.Checked ? (byte)1 : (byte)0;
                conn.Open();
                query = "UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, QueQuan = @QueQuan, MaLop = @MaLop WHERE MaSV = @MaSV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", sua.Text);
                    cmd.Parameters.AddWithValue("@Hoten", name.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", date.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioitinh_temp);
                    cmd.Parameters.AddWithValue("@QueQuan", quequan.Text);
                    cmd.Parameters.AddWithValue("@MaLop", lop.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disable_infor();
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
    }

