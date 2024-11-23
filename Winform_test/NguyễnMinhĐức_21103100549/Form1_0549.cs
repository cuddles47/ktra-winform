using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenMinhDuc_21103100549
{
    public partial class Form1_0549 : Form
    {
        
        string connectionString = @"Data Source=DESKTOP-1JCPNUT;Initial Catalog=QuanLySinhVien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Form1_0549()
        {
            InitializeComponent();
            LoadComboBoxMaLop(); 
            LoadData(); 
            LoadSiSoLop(); 
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(); 
            LoadSiSoLop(); 
        }

        private void LoadComboBoxMaLop()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT malop FROM tblLop";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Tất cả"); 

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["malop"].ToString());
                    }
                    comboBox1.SelectedIndex = 0; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải mã lớp: " + ex.Message);
                }
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string selectedMaLop = comboBox1.Text;

                
                string query = string.IsNullOrEmpty(selectedMaLop) || selectedMaLop == "Tất cả"
                    ? "SELECT * FROM tblSinhVien"
                    : "SELECT * FROM tblSinhVien WHERE malop = @malop";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    if (!string.IsNullOrEmpty(selectedMaLop) && selectedMaLop != "Tất cả")
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@malop", selectedMaLop);
                    }
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblSinhVien (masv, hoten, ngaysinh, gioitinh, sdt, diachi, malop) " +
                               "VALUES (@masv, @hoten, @ngaysinh, @gioitinh, @sdt, @diachi, @malop)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@masv", textBox1.Text);
                cmd.Parameters.AddWithValue("@hoten", textBox2.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@gioitinh", comboBox2.Text);
                cmd.Parameters.AddWithValue("@sdt", textBox3.Text);
                cmd.Parameters.AddWithValue("@diachi", textBox4.Text);
                cmd.Parameters.AddWithValue("@malop", comboBox1.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!");
                    LoadData(); 
                    LoadSiSoLop(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblSinhVien SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, " +
                               "sdt = @sdt, diachi = @diachi, malop = @malop WHERE masv = @masv";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@masv", textBox1.Text);
                cmd.Parameters.AddWithValue("@hoten", textBox2.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@gioitinh", comboBox2.Text);
                cmd.Parameters.AddWithValue("@sdt", textBox3.Text);
                cmd.Parameters.AddWithValue("@diachi", textBox4.Text);
                cmd.Parameters.AddWithValue("@malop", comboBox1.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                    LoadData(); 
                    LoadSiSoLop(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tblSinhVien WHERE masv = @masv";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@masv", textBox1.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa sinh viên thành công!");
                    LoadData(); 
                    LoadSiSoLop(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }

        private void LoadSiSoLop()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string selectedMaLop = comboBox1.Text;
                string query = string.IsNullOrEmpty(selectedMaLop) || selectedMaLop == "Tất cả"
                    ? "SELECT COUNT(*) FROM tblSinhVien"
                    : "SELECT COUNT(*) FROM tblSinhVien WHERE malop = @malop";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    if (!string.IsNullOrEmpty(selectedMaLop) && selectedMaLop != "Tất cả")
                    {
                        cmd.Parameters.AddWithValue("@malop", selectedMaLop);
                    }

                    int siSo = (int)cmd.ExecuteScalar();
                    textBox5.Text = siSo.ToString(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tính sĩ số lớp: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                
                textBox1.Text = row.Cells["masv"].Value.ToString();
                textBox2.Text = row.Cells["hoten"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);
                comboBox2.Text = row.Cells["gioitinh"].Value.ToString();
                textBox3.Text = row.Cells["sdt"].Value.ToString();
                textBox4.Text = row.Cells["diachi"].Value.ToString();
                comboBox1.Text = row.Cells["malop"].Value.ToString();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form3_0549 form3 = new Form3_0549();
            form3.Show(); // Hiển thị lại Form3
            this.Close();
        }

        private void hIỂNTHỊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_0549 form2 = new Form2_0549();
            form2.Show();
        }


    }
}
