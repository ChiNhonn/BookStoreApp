using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class BookListForm : Form
    {
        BindingList<string> bookList = new BindingList<string>();
        public BookListForm()
        {
            InitializeComponent();
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            bookList = new BindingList<string>();
            {
                bookList.Add("Book 1");
                bookList.Add("Book 2");
                bookList.Add("Book 3");
                bookList.Add("Book 4");
                lstBook.DataSource = bookList;
                CapNhatSoLuong();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newsach = txtBookTitle.Text.Trim();
            if (string.IsNullOrEmpty(newsach))
            {
                MessageBox.Show("Bạn chưa nhập tên sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookTitle.Focus();
                return;
            }
            bool exist = false;
            foreach (string sachcu in bookList)
            {
                if (sachcu.ToLower() == newsach.ToLower())
                {
                    exist = true;
                    break;
                }
            }
            if (exist)
            {
                MessageBox.Show("Sách đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookTitle.SelectAll();
                txtBookTitle.Focus();
                return;
            }
            bookList.Add(newsach);
            CapNhatSoLuong();
            txtBookTitle.Clear();
            txtBookTitle.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBook.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int bookRm = lstBook.SelectedIndex;
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa sách '{bookList[bookRm]}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bookList.RemoveAt(bookRm);
                    CapNhatSoLuong();

                }
            }
            txtBookTitle.Focus();
        }

        private void CapNhatSoLuong()
        {
            lblTotal.Text = "Tổng số sách: " + bookList.Count + " cuốn";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstBook.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else
            {
                string tenmoi = txtBookTitle.Text;
                if(tenmoi == "")
                {
                    MessageBox.Show("Tên sách không được để trống!");
                    return;
                }
                int index = lstBook.SelectedIndex;
                bookList[index] = tenmoi;
            }
            txtBookTitle.Clear();
            txtBookTitle.Focus();

        }
    }
}
