namespace BookStore
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuDangXuat = new ToolStripMenuItem();
            ToolStripMenuThoat = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            ToolStripMenuQLSach = new ToolStripMenuItem();
            quánLýSáchToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuQLNguoiDung = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuDoanhThu = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            sắpXếpLớpToolStripMenuItem = new ToolStripMenuItem();
            sắpXếpNgangHorizontalToolStripMenuItem = new ToolStripMenuItem();
            sắpXếpDọcToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            lblThoiGian = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, ToolStripMenuQLSach, thốngKêToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuDangXuat, ToolStripMenuThoat, toolStripMenuItem1 });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.H;
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "&Hệ thống";
            // 
            // ToolStripMenuDangXuat
            // 
            ToolStripMenuDangXuat.Name = "ToolStripMenuDangXuat";
            ToolStripMenuDangXuat.Size = new Size(224, 26);
            ToolStripMenuDangXuat.Text = "Đăng xuất";
            ToolStripMenuDangXuat.Click += ToolStripMenuDangXuat_Click;
            // 
            // ToolStripMenuThoat
            // 
            ToolStripMenuThoat.Image = (Image)resources.GetObject("ToolStripMenuThoat.Image");
            ToolStripMenuThoat.Name = "ToolStripMenuThoat";
            ToolStripMenuThoat.ShortcutKeys = Keys.Control | Keys.E;
            ToolStripMenuThoat.Size = new Size(224, 26);
            ToolStripMenuThoat.Text = "&Thoát";
            ToolStripMenuThoat.Click += ToolStripMenuThoat_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // ToolStripMenuQLSach
            // 
            ToolStripMenuQLSach.DropDownItems.AddRange(new ToolStripItem[] { quánLýSáchToolStripMenuItem, ToolStripMenuQLNguoiDung });
            ToolStripMenuQLSach.Name = "ToolStripMenuQLSach";
            ToolStripMenuQLSach.Size = new Size(77, 24);
            ToolStripMenuQLSach.Text = "Quản lý ";
            // 
            // quánLýSáchToolStripMenuItem
            // 
            quánLýSáchToolStripMenuItem.Name = "quánLýSáchToolStripMenuItem";
            quánLýSáchToolStripMenuItem.Size = new Size(227, 26);
            quánLýSáchToolStripMenuItem.Text = "Quán lý sách";
            quánLýSáchToolStripMenuItem.Click += quánLýSáchToolStripMenuItem_Click;
            // 
            // ToolStripMenuQLNguoiDung
            // 
            ToolStripMenuQLNguoiDung.Name = "ToolStripMenuQLNguoiDung";
            ToolStripMenuQLNguoiDung.Size = new Size(227, 26);
            ToolStripMenuQLNguoiDung.Text = "Quản lý người dùng ";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuDoanhThu });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(156, 24);
            thốngKêToolStripMenuItem.Text = "Thống kê / Báo cáo ";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // ToolStripMenuDoanhThu
            // 
            ToolStripMenuDoanhThu.Name = "ToolStripMenuDoanhThu";
            ToolStripMenuDoanhThu.Size = new Size(161, 26);
            ToolStripMenuDoanhThu.Text = "Doanh thu";
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sắpXếpLớpToolStripMenuItem, sắpXếpNgangHorizontalToolStripMenuItem, sắpXếpDọcToolStripMenuItem });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(68, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // sắpXếpLớpToolStripMenuItem
            // 
            sắpXếpLớpToolStripMenuItem.Name = "sắpXếpLớpToolStripMenuItem";
            sắpXếpLớpToolStripMenuItem.Size = new Size(275, 26);
            sắpXếpLớpToolStripMenuItem.Text = "Sắp xếp lớp (Cascade)";
            sắpXếpLớpToolStripMenuItem.Click += sắpXếpLớpToolStripMenuItem_Click;
            // 
            // sắpXếpNgangHorizontalToolStripMenuItem
            // 
            sắpXếpNgangHorizontalToolStripMenuItem.Name = "sắpXếpNgangHorizontalToolStripMenuItem";
            sắpXếpNgangHorizontalToolStripMenuItem.Size = new Size(275, 26);
            sắpXếpNgangHorizontalToolStripMenuItem.Text = "Sắp xếp ngang (Horizontal)";
            sắpXếpNgangHorizontalToolStripMenuItem.Click += sắpXếpNgangHorizontalToolStripMenuItem_Click;
            // 
            // sắpXếpDọcToolStripMenuItem
            // 
            sắpXếpDọcToolStripMenuItem.Name = "sắpXếpDọcToolStripMenuItem";
            sắpXếpDọcToolStripMenuItem.Size = new Size(275, 26);
            sắpXếpDọcToolStripMenuItem.Text = "Sắp xếp dọc(Vertical)";
            sắpXếpDọcToolStripMenuItem.Click += sắpXếpDọcToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUser, lblTime, lblThoiGian });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(117, 20);
            lblUser.Text = "Xin chào: Admin";
            // 
            // lblTime
            // 
            lblTime.DisplayStyle = ToolStripItemDisplayStyle.None;
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 20);
            lblTime.Text = "00/00/0000 00:00:00";
            // 
            // lblThoiGian
            // 
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(668, 20);
            lblThoiGian.Spring = true;
            lblThoiGian.Text = "00/00/0000 00:00:00";
            lblThoiGian.TextAlign = ContentAlignment.MiddleRight;
            lblThoiGian.Click += toolStripStatusLabel1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuDangXuat;
        private ToolStripMenuItem ToolStripMenuThoat;
        private ToolStripMenuItem ToolStripMenuQLSach;
        private ToolStripMenuItem quánLýSáchToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuQLNguoiDung;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuDoanhThu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblTime;
        private ToolStripStatusLabel lblThoiGian;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem sắpXếpLớpToolStripMenuItem;
        private ToolStripMenuItem sắpXếpNgangHorizontalToolStripMenuItem;
        private ToolStripMenuItem sắpXếpDọcToolStripMenuItem;
    }
}