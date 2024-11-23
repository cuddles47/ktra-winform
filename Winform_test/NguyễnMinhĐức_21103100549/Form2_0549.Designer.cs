namespace NguyenMinhDuc_21103100549
{
    partial class Form2_0549
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.buttonHienThiDanhSach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(302, 29);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỚP";
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(12, 84);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(776, 354);
            this.dataGridViewSinhVien.TabIndex = 2;
            // 
            // buttonHienThiDanhSach
            // 
            this.buttonHienThiDanhSach.Location = new System.Drawing.Point(429, 27);
            this.buttonHienThiDanhSach.Name = "buttonHienThiDanhSach";
            this.buttonHienThiDanhSach.Size = new System.Drawing.Size(75, 23);
            this.buttonHienThiDanhSach.TabIndex = 3;
            this.buttonHienThiDanhSach.Text = "HIỂN THỊ";
            this.buttonHienThiDanhSach.UseVisualStyleBackColor = true;
            this.buttonHienThiDanhSach.Click += new System.EventHandler(this.buttonHienThiDanhSach_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2_0549
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonHienThiDanhSach);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLop);
            this.Name = "Form2_0549";
            this.Text = "Form2_0549";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.Button buttonHienThiDanhSach;
        private System.Windows.Forms.Button button1;
    }
}