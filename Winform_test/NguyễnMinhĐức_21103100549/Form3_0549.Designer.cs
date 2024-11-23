namespace NguyenMinhDuc_21103100549
{
    partial class Form3_0549
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
            this.components = new System.ComponentModel.Container();
            this.MENU = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quảnLýThôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhSáchLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENU
            // 
            this.MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýThôngTinSinhViênToolStripMenuItem});
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(218, 26);
            // 
            // quảnLýThôngTinSinhViênToolStripMenuItem
            // 
            this.quảnLýThôngTinSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịDanhSáchToolStripMenuItem});
            this.quảnLýThôngTinSinhViênToolStripMenuItem.Name = "quảnLýThôngTinSinhViênToolStripMenuItem";
            this.quảnLýThôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.quảnLýThôngTinSinhViênToolStripMenuItem.Text = "Quản lý thông tin sinh viên";
            // 
            // hiểnThịDanhSáchToolStripMenuItem
            // 
            this.hiểnThịDanhSáchToolStripMenuItem.Name = "hiểnThịDanhSáchToolStripMenuItem";
            this.hiểnThịDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.hiểnThịDanhSáchToolStripMenuItem.Text = "Hiển thị danh sách lớp";
            this.hiểnThịDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịDanhSáchToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSToolStripMenuItem,
            this.quảnLýDanhSáchLớpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSToolStripMenuItem
            // 
            this.quảnLýSToolStripMenuItem.Name = "quảnLýSToolStripMenuItem";
            this.quảnLýSToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.quảnLýSToolStripMenuItem.Text = "Quản lý thông tin sinh viên";
            this.quảnLýSToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSToolStripMenuItem_Click);
            // 
            // quảnLýDanhSáchLớpToolStripMenuItem
            // 
            this.quảnLýDanhSáchLớpToolStripMenuItem.Name = "quảnLýDanhSáchLớpToolStripMenuItem";
            this.quảnLýDanhSáchLớpToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.quảnLýDanhSáchLớpToolStripMenuItem.Text = "Hiển thị danh sách lớp";
            this.quảnLýDanhSáchLớpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýDanhSáchLớpToolStripMenuItem_Click);
            // 
            // Form3_0549
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3_0549";
            this.Text = "Form3_0549";
            this.Load += new System.EventHandler(this.Form3_0549_Load);
            this.MENU.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MENU;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịDanhSáchToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhSáchLớpToolStripMenuItem;
    }
}