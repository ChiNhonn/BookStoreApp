namespace BookStore
{
    partial class BookManagementForm
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
            grpBookInf = new GroupBox();
            btnXoaSach = new Button();
            btnLamMoiForm = new Button();
            btnSuaSach = new Button();
            btnThemSach = new Button();
            cboTheLoai = new ComboBox();
            dateNgayXuatBan = new DateTimePicker();
            numGiaTien = new NumericUpDown();
            txtTenSach = new TextBox();
            lblTheLoai = new Label();
            lblNgayXuatBan = new Label();
            lblGiatien = new Label();
            lblTenSach = new Label();
            grpBookList = new GroupBox();
            lstBooks = new ListBox();
            lblTongGiaSach = new Label();
            grpBookInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGiaTien).BeginInit();
            grpBookList.SuspendLayout();
            SuspendLayout();
            // 
            // grpBookInf
            // 
            grpBookInf.Controls.Add(btnXoaSach);
            grpBookInf.Controls.Add(btnLamMoiForm);
            grpBookInf.Controls.Add(btnSuaSach);
            grpBookInf.Controls.Add(btnThemSach);
            grpBookInf.Controls.Add(cboTheLoai);
            grpBookInf.Controls.Add(dateNgayXuatBan);
            grpBookInf.Controls.Add(numGiaTien);
            grpBookInf.Controls.Add(txtTenSach);
            grpBookInf.Controls.Add(lblTheLoai);
            grpBookInf.Controls.Add(lblNgayXuatBan);
            grpBookInf.Controls.Add(lblGiatien);
            grpBookInf.Controls.Add(lblTenSach);
            grpBookInf.Location = new Point(25, 26);
            grpBookInf.Name = "grpBookInf";
            grpBookInf.Size = new Size(961, 333);
            grpBookInf.TabIndex = 0;
            grpBookInf.TabStop = false;
            grpBookInf.Text = "Thông tin chi tiết sách ";
            grpBookInf.Enter += grpBookInf_Enter;
            // 
            // btnXoaSach
            // 
            btnXoaSach.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoaSach.Location = new Point(301, 278);
            btnXoaSach.Name = "btnXoaSach";
            btnXoaSach.Size = new Size(139, 50);
            btnXoaSach.TabIndex = 11;
            btnXoaSach.Text = "Xóa sách";
            btnXoaSach.UseVisualStyleBackColor = true;
            btnXoaSach.Click += btnXoaSach_Click;
            // 
            // btnLamMoiForm
            // 
            btnLamMoiForm.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLamMoiForm.Location = new Point(768, 277);
            btnLamMoiForm.Name = "btnLamMoiForm";
            btnLamMoiForm.Size = new Size(187, 52);
            btnLamMoiForm.TabIndex = 10;
            btnLamMoiForm.Text = "Làm mới form";
            btnLamMoiForm.UseVisualStyleBackColor = true;
            btnLamMoiForm.Click += btnLamMoiForm_Click;
            // 
            // btnSuaSach
            // 
            btnSuaSach.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSuaSach.Location = new Point(623, 275);
            btnSuaSach.Name = "btnSuaSach";
            btnSuaSach.Size = new Size(139, 52);
            btnSuaSach.TabIndex = 9;
            btnSuaSach.Text = "Cập nhập";
            btnSuaSach.UseVisualStyleBackColor = true;
            btnSuaSach.Click += btnSuaSach_Click;
            // 
            // btnThemSach
            // 
            btnThemSach.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThemSach.Location = new Point(463, 276);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(139, 54);
            btnThemSach.TabIndex = 8;
            btnThemSach.Text = "Thêm sách";
            btnThemSach.UseVisualStyleBackColor = true;
            btnThemSach.Click += btnThemSach_Click;
            // 
            // cboTheLoai
            // 
            cboTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTheLoai.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(263, 205);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(250, 38);
            cboTheLoai.TabIndex = 7;
            cboTheLoai.SelectedIndexChanged += cboTheLoai_SelectedIndexChanged;
            // 
            // dateNgayXuatBan
            // 
            dateNgayXuatBan.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dateNgayXuatBan.Format = DateTimePickerFormat.Custom;
            dateNgayXuatBan.Location = new Point(263, 152);
            dateNgayXuatBan.Name = "dateNgayXuatBan";
            dateNgayXuatBan.Size = new Size(250, 37);
            dateNgayXuatBan.TabIndex = 6;
            // 
            // numGiaTien
            // 
            numGiaTien.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            numGiaTien.Location = new Point(263, 91);
            numGiaTien.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numGiaTien.Name = "numGiaTien";
            numGiaTien.Size = new Size(258, 37);
            numGiaTien.TabIndex = 5;
            // 
            // txtTenSach
            // 
            txtTenSach.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 163);
            txtTenSach.Location = new Point(263, 37);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.PlaceholderText = "Nhập tên sách...";
            txtTenSach.Size = new Size(622, 37);
            txtTenSach.TabIndex = 4;
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTheLoai.Location = new Point(43, 212);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(102, 31);
            lblTheLoai.TabIndex = 3;
            lblTheLoai.Text = "Thể loại:";
            // 
            // lblNgayXuatBan
            // 
            lblNgayXuatBan.AutoSize = true;
            lblNgayXuatBan.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNgayXuatBan.Location = new Point(43, 156);
            lblNgayXuatBan.Name = "lblNgayXuatBan";
            lblNgayXuatBan.Size = new Size(172, 31);
            lblNgayXuatBan.TabIndex = 2;
            lblNgayXuatBan.Text = "Ngày xuất bản:";
            // 
            // lblGiatien
            // 
            lblGiatien.AutoSize = true;
            lblGiatien.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblGiatien.Location = new Point(40, 97);
            lblGiatien.Name = "lblGiatien";
            lblGiatien.Size = new Size(165, 31);
            lblGiatien.TabIndex = 1;
            lblGiatien.Text = "Giá tiền(VND):";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTenSach.Location = new Point(43, 43);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(114, 31);
            lblTenSach.TabIndex = 0;
            lblTenSach.Text = "Tên sách: ";
            // 
            // grpBookList
            // 
            grpBookList.Controls.Add(lstBooks);
            grpBookList.Location = new Point(25, 365);
            grpBookList.Name = "grpBookList";
            grpBookList.Size = new Size(961, 187);
            grpBookList.TabIndex = 1;
            grpBookList.TabStop = false;
            grpBookList.Text = "Danh sách Sách";
            // 
            // lstBooks
            // 
            lstBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 28;
            lstBooks.Location = new Point(21, 31);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(919, 144);
            lstBooks.TabIndex = 0;
            lstBooks.SelectedIndexChanged += lstBooks_SelectedIndexChanged;
            // 
            // lblTongGiaSach
            // 
            lblTongGiaSach.AutoSize = true;
            lblTongGiaSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTongGiaSach.Location = new Point(25, 569);
            lblTongGiaSach.Name = "lblTongGiaSach";
            lblTongGiaSach.Size = new Size(0, 28);
            lblTongGiaSach.TabIndex = 2;
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 618);
            Controls.Add(lblTongGiaSach);
            Controls.Add(grpBookList);
            Controls.Add(grpBookInf);
            Name = "BookManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookManagementForm";
            Load += BookManagementForm_Load;
            grpBookInf.ResumeLayout(false);
            grpBookInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGiaTien).EndInit();
            grpBookList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBookInf;
        private GroupBox grpBookList;
        private Label lblTheLoai;
        private Label lblNgayXuatBan;
        private Label lblGiatien;
        private Label lblTenSach;
        private ComboBox cboTheLoai;
        private DateTimePicker dateNgayXuatBan;
        private NumericUpDown numGiaTien;
        private TextBox txtTenSach;
        private Button btnLamMoiForm;
        private Button btnSuaSach;
        private Button btnThemSach;
        private ListBox lstBooks;
        private Button btnXoaSach;
        private Label lblTongGiaSach;
    }
}