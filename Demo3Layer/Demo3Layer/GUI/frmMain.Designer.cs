namespace Demo3Layer.GUI
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            dSLớpToolStripMenuItem = new ToolStripMenuItem();
            dSSinhVienToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            đóngỨngDụngToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            xemThôngTinToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1546, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dSLớpToolStripMenuItem, dSSinhVienToolStripMenuItem, toolStripSeparator1, đóngỨngDụngToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(153, 36);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // dSLớpToolStripMenuItem
            // 
            dSLớpToolStripMenuItem.Name = "dSLớpToolStripMenuItem";
            dSLớpToolStripMenuItem.Size = new Size(318, 44);
            dSLớpToolStripMenuItem.Text = "DS Lớp";
            dSLớpToolStripMenuItem.Click += showDSLop_Click;
            // 
            // dSSinhVienToolStripMenuItem
            // 
            dSSinhVienToolStripMenuItem.Name = "dSSinhVienToolStripMenuItem";
            dSSinhVienToolStripMenuItem.Size = new Size(318, 44);
            dSSinhVienToolStripMenuItem.Text = "DS Sinh Vien";
            dSSinhVienToolStripMenuItem.Click += dSSinhVienToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(315, 6);
            // 
            // đóngỨngDụngToolStripMenuItem
            // 
            đóngỨngDụngToolStripMenuItem.Name = "đóngỨngDụngToolStripMenuItem";
            đóngỨngDụngToolStripMenuItem.Size = new Size(318, 44);
            đóngỨngDụngToolStripMenuItem.Text = "Đóng ứng dụng";
            đóngỨngDụngToolStripMenuItem.Click += exit_ToolStripMenuItem_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xemThôngTinToolStripMenuItem, đăngXuấtToolStripMenuItem1 });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(135, 36);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // xemThôngTinToolStripMenuItem
            // 
            xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            xemThôngTinToolStripMenuItem.Size = new Size(301, 44);
            xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            xemThôngTinToolStripMenuItem.Click += userInfo_ToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            đăngXuấtToolStripMenuItem1.Size = new Size(301, 44);
            đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem1.Click += logout_ToolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(30, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1482, 844);
            panel1.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 928);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem dSLớpToolStripMenuItem;
        private ToolStripMenuItem dSSinhVienToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem đóngỨngDụngToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private Panel panel1;
    }
}