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
    public partial class MainForm : Form
    {
        private string _currentUser;
        public MainForm()
        {
            InitializeComponent();
            _currentUser = "Admin";
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Xin chào, " + _currentUser;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss");
        }

        private void quánLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookManagementForm());
        }

        private void ToolStripMenuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cửaSổToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sắpXếpNgangHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void sắpXếpLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void sắpXếpDọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ToolStripMenuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }
        private void OpenChildForm(Form childForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
            if (frm.GetType() == childForm.GetType())
                {
                    frm.Activate(); 
                    return;
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
