using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenMinhDuc_21103100549
{
    public partial class Form3_0549 : Form
    {
        public Form3_0549()
        {
            InitializeComponent();
        }

        private void hiểnThịDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form3_0549_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýDanhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_0549 form2 = new Form2_0549();
            form2.Show();
            this.Hide();
        }

        private void quảnLýSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_0549 form1 = new Form1_0549();
            form1.Show(); 
            this.Hide();
        }
    }
}
