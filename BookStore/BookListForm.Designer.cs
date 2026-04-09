namespace BookStore
{
    partial class BookListForm
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
            lblBookTitle = new Label();
            txtBookTitle = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lstBook = new ListBox();
            lblTotal = new Label();
            btnSua = new Button();
            SuspendLayout();
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBookTitle.Location = new Point(30, 109);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(267, 31);
            lblBookTitle.TabIndex = 0;
            lblBookTitle.Text = "Nhập tên đầu sách mới:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBookTitle.Location = new Point(329, 108);
            txtBookTitle.Multiline = true;
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Nhập tên sách mới..";
            txtBookTitle.Size = new Size(381, 43);
            txtBookTitle.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAdd.Location = new Point(78, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 47);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm sách ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnRemove.Location = new Point(539, 198);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(171, 47);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Xóa sách";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lstBook
            // 
            lstBook.FormattingEnabled = true;
            lstBook.Location = new Point(78, 298);
            lstBook.Name = "lstBook";
            lstBook.Size = new Size(632, 104);
            lstBook.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(611, 421);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "label1";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSua.Location = new Point(301, 198);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(171, 47);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa sách";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSua);
            Controls.Add(lblTotal);
            Controls.Add(lstBook);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtBookTitle);
            Controls.Add(lblBookTitle);
            Name = "BookListForm";
            Text = "BookListForm";
            Load += BookListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookTitle;
        private TextBox txtBookTitle;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox lstBook;
        private Label lblTotal;
        private Button btnSua;
    }
}