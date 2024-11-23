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
    public partial class Form2_0549 : Form
    {
        string connectionString = @"Data Source=DESKTOP-1JCPNUT;Initial Catalog=QuanLySinhVien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Form2_0549()
        {
            InitializeComponent();
            LoadComboBoxMaLop();
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
                    comboBoxLop.Items.Clear();
                    comboBoxLop.Items.Add("Tất cả");
                    while (reader.Read())
                    {
                        comboBoxLop.Items.Add(reader["malop"].ToString());
                    }
                    comboBoxLop.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải lớp: " + ex.Message);
                }
            }
        }

        private void buttonHienThiDanhSach_Click(object sender, EventArgs e)
        {
            string selectedMaLop = comboBoxLop.SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectedMaLop))
            {
                MessageBox.Show("Vui lòng chọn lớp.");
                return;
            }

            string query = selectedMaLop == "Tất cả"
                ? "SELECT * FROM tblSinhVien"
                : "SELECT * FROM tblSinhVien WHERE malop = @malop";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    if (selectedMaLop != "Tất cả")
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@malop", selectedMaLop);
                    }

                    adapter.Fill(dt);

                    
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có sinh viên nào trong lớp này.");
                    }
                    else
                    {
                        dataGridViewSinhVien.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị danh sách sinh viên: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3_0549 form3 = new Form3_0549();
            form3.Show(); // Hiển thị lại Form3
            this.Close();
        }
    }
}
