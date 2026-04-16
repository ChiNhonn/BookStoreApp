using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Models;

namespace BookStore
{
    public partial class BookManagementForm : Form
    {
        List<Category> theloai = new List<Category>();
        List<Book> Sach = new List<Book>();
        public BookManagementForm()
        {
            InitializeComponent();
        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpBookInf_Enter(object sender, EventArgs e)
        {

        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            theloai.Add(new Category { Id = "C01", Name = "Văn học trong nước" });
            theloai.Add(new Category { Id = "C02", Name = "Khoa học - Viễn tưởng" });
            theloai.Add(new Category { Id = "C03", Name = "Kinh tế - Khởi nghiệp" });
            cboTheLoai.DataSource = theloai;
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            try
            {
                string tensach = txtTenSach.Text.Trim();
                decimal giatien = numGiaTien.Value;
                Category theloai = (Category)cboTheLoai.SelectedItem;
                if (string.IsNullOrEmpty(tensach))
                {
                    MessageBox.Show("Tên sách không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenSach.Focus();
                    return;
                }
                string idmoi = "B" + DateTime.Now.Millisecond.ToString();
                Book sachmoi = new Book { Id = idmoi, Title = tensach, Price = giatien, Category = theloai};
                Sach.Add(sachmoi);
                lstBooks.DataSource = null;
                lstBooks.DataSource = Sach;

                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Clear();
                cboTheLoai.SelectedIndex = 0;
                numGiaTien.Value = 0;
                dateNgayXuatBan.Value = DateTime.Now;
                txtTenSach.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá tiền phải là một số hợp lệ!", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numGiaTien.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if(lstBooks.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một sách để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Book sachcansua = (Book)lstBooks.SelectedItem;
                sachcansua.Title = txtTenSach.Text.Trim();
                sachcansua.Price = numGiaTien.Value;
                Category theloai = (Category)cboTheLoai.SelectedItem;
                sachcansua.CategoryId = theloai.Id;
                sachcansua.Category = theloai;
                lstBooks.DataSource = null;
                lstBooks.DataSource = Sach;
                MessageBox.Show("Sửa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Clear();
                cboTheLoai.SelectedIndex = 0;
                numGiaTien.Value = 0;
                dateNgayXuatBan.Value = DateTime.Now;
                txtTenSach.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá tiền phải là một số hợp lệ!", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numGiaTien.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoiForm_Click(object sender, EventArgs e)
        {
            txtTenSach.Clear();
            numGiaTien.Value = 0;
            cboTheLoai.SelectedIndex = 0;
            dateNgayXuatBan.Value = DateTime.Now;
            txtTenSach.Focus();
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBooks.SelectedItem != null)
            {
                Book sachduocchon = (Book)lstBooks.SelectedItem;
                txtTenSach.Text = sachduocchon.Title;
                numGiaTien.Value = sachduocchon.Price;
                foreach(Category cat in theloai) {
                    if(cat.Id == sachduocchon.CategoryId)
                    {
                        cboTheLoai.SelectedItem = cat;
                        break;
                    }
                }
            }
        }
    }
}
