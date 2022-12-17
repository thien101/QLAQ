namespace QLAoQuan
{
    partial class TrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_dn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_dk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_dx = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_out = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_infor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_muahang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_muasp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_tracuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_findsp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_hethong,
            this.mnu_infor,
            this.mnu_muahang,
            this.mnu_tracuu,
            this.mnu_baocao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_hethong
            // 
            this.mnu_hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_dn,
            this.mnu_dk,
            this.mnu_dx,
            this.mnu_out});
            this.mnu_hethong.Name = "mnu_hethong";
            this.mnu_hethong.Size = new System.Drawing.Size(88, 24);
            this.mnu_hethong.Text = "Hệ Thống";
            // 
            // mnu_dn
            // 
            this.mnu_dn.Name = "mnu_dn";
            this.mnu_dn.Size = new System.Drawing.Size(224, 26);
            this.mnu_dn.Text = "Đăng Nhập";
            this.mnu_dn.Click += new System.EventHandler(this.mnu_dn_Click);
            // 
            // mnu_dk
            // 
            this.mnu_dk.Name = "mnu_dk";
            this.mnu_dk.Size = new System.Drawing.Size(224, 26);
            this.mnu_dk.Text = "Đăng ký";
            // 
            // mnu_dx
            // 
            this.mnu_dx.Name = "mnu_dx";
            this.mnu_dx.Size = new System.Drawing.Size(224, 26);
            this.mnu_dx.Text = "Đăng Xuất";
            // 
            // mnu_out
            // 
            this.mnu_out.Name = "mnu_out";
            this.mnu_out.Size = new System.Drawing.Size(224, 26);
            this.mnu_out.Text = "Thoát";
            this.mnu_out.Click += new System.EventHandler(this.mnu_out_Click);
            // 
            // mnu_infor
            // 
            this.mnu_infor.Name = "mnu_infor";
            this.mnu_infor.Size = new System.Drawing.Size(141, 24);
            this.mnu_infor.Text = "Thông tin cá nhân";
            // 
            // mnu_muahang
            // 
            this.mnu_muahang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_muasp});
            this.mnu_muahang.Name = "mnu_muahang";
            this.mnu_muahang.Size = new System.Drawing.Size(92, 24);
            this.mnu_muahang.Text = "Mua Hàng";
            // 
            // mnu_muasp
            // 
            this.mnu_muasp.Name = "mnu_muasp";
            this.mnu_muasp.Size = new System.Drawing.Size(150, 26);
            this.mnu_muasp.Text = "Áo Quần";
            // 
            // mnu_tracuu
            // 
            this.mnu_tracuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_findsp});
            this.mnu_tracuu.Name = "mnu_tracuu";
            this.mnu_tracuu.Size = new System.Drawing.Size(73, 24);
            this.mnu_tracuu.Text = "Tra Cứu";
            // 
            // mnu_findsp
            // 
            this.mnu_findsp.Name = "mnu_findsp";
            this.mnu_findsp.Size = new System.Drawing.Size(150, 26);
            this.mnu_findsp.Text = "Áo Quần";
            // 
            // mnu_baocao
            // 
            this.mnu_baocao.Name = "mnu_baocao";
            this.mnu_baocao.Size = new System.Drawing.Size(79, 24);
            this.mnu_baocao.Text = "Báo Cáo";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_hethong;
        private System.Windows.Forms.ToolStripMenuItem mnu_dn;
        private System.Windows.Forms.ToolStripMenuItem mnu_dx;
        private System.Windows.Forms.ToolStripMenuItem mnu_out;
        private System.Windows.Forms.ToolStripMenuItem mnu_muahang;
        private System.Windows.Forms.ToolStripMenuItem mnu_muasp;
        private System.Windows.Forms.ToolStripMenuItem mnu_tracuu;
        private System.Windows.Forms.ToolStripMenuItem mnu_findsp;
        private System.Windows.Forms.ToolStripMenuItem mnu_baocao;
        private System.Windows.Forms.ToolStripMenuItem mnu_dk;
        private System.Windows.Forms.ToolStripMenuItem mnu_infor;
    }
}