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
        BindingList<Book> Sach = new BindingList<Book>();
        public BookManagementForm()
        {
            InitializeComponent();
        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            theloai.Add(new Category { Id = "C01", Name = "Văn học trong nước" });
            theloai.Add(new Category { Id = "C02", Name = "Khoa học - Viễn tưởng" });
            theloai.Add(new Category { Id = "C03", Name = "Kinh tế - Khởi nghiệp" });
            cboTheLoai.DataSource = theloai;
            Sach.Add(new Book { Id = "B01", Title = "Đắc Nhân Tâm", Price = 50000, CategoryId = "C01", Category = theloai[0], PublishDate = new DateTime(1936, 10, 1) });
            Sach.Add(new Book { Id = "B02", Title = "Dế Mèn Phiêu Lưu Ký", Price = 30000, CategoryId = "C01", Category = theloai[0], PublishDate = new DateTime(1941, 5, 1) });
            Sach.Add(new Book { Id = "B03", Title = "Lão Hạc", Price = 20000, CategoryId = "C01", Category = theloai[0], PublishDate = new DateTime(1908, 1, 1) });
            dgvBooks.DataSource = Sach;
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
                Book sachmoi = new Book { Id = idmoi, Title = tensach, Price = giatien, Category = theloai };
                Sach.Add(sachmoi);
                dgvBooks.DataSource = null;
                dgvBooks.DataSource = Sach;
                CapNhapThongKe();

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
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sách để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Book sachcansua = (Book)dgvBooks.SelectedRows[0].DataBoundItem;
                sachcansua.Title = txtTenSach.Text.Trim();
                sachcansua.Price = numGiaTien.Value;
                Category theloai = (Category)cboTheLoai.SelectedItem;
                sachcansua.CategoryId = theloai.Id;
                sachcansua.Category = theloai;
                dgvBooks.DataSource = null;
                dgvBooks.DataSource = Sach;
                CapNhapThongKe();

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
            CapNhapThongKe();
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)   
            {
                Book sachduocchon = (Book)dgvBooks.SelectedRows[0].DataBoundItem;
                txtTenSach.Text = sachduocchon.Title;
                numGiaTien.Value = sachduocchon.Price;
                foreach (Category cat in theloai)
                {
                    if (cat.Id == sachduocchon.CategoryId)
                    {
                        cboTheLoai.SelectedItem = cat;
                        break;
                    }
                }
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sách để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Book sachcanxoa = (Book)dgvBooks.SelectedRows[0].DataBoundItem;
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa sách '{sachcanxoa.Title}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Sach.Remove(sachcanxoa);
                dgvBooks.DataSource = null;
                dgvBooks.DataSource = Sach;
                MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Clear();
                cboTheLoai.SelectedIndex = 0;
                numGiaTien.Value = 0;
                dateNgayXuatBan.Value = DateTime.Now;
                txtTenSach.Focus();
            }
            CapNhapThongKe();
        }
        private void CapNhapThongKe()
        {
            decimal tonggiasach = 0;
            foreach (Book sach in Sach)
            {
                tonggiasach += sach.Price;

            }
            lblTongGiaSach.Text = $"Tổng giá sách: {tonggiasach:N0} VND";
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            int cursor = txtTenSach.SelectionStart;
            txtTenSach.Text = txtTenSach.Text.ToUpper();
            txtTenSach.SelectionStart = cursor;
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Book sachduocchon = (Book)dgvBooks.Rows[e.RowIndex].DataBoundItem;
                txtTenSach.Text = sachduocchon.Title;
                numGiaTien.Value = sachduocchon.Price;
                foreach (Category cat in theloai)
                {
                    if (cat.Id == sachduocchon.CategoryId)
                    {
                        cboTheLoai.SelectedItem = cat;
                        break;
                    }
                }
            }
        }

    }
}
