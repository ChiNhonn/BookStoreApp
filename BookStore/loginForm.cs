namespace BookStore
{
    public partial class loginForm : Form
    {
        int loginAttemp = 0;
        public loginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string correctUser = "admin";
            string correctPassword = "123";

            string inputUser = txtUser.Text.Trim();
            string inputPass = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(inputUser) || string.IsNullOrEmpty(inputPass))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }
            try
            {
                int pin = int.Parse(inputPass);
                if (inputUser == correctUser && inputPass == correctPassword)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    loginAttemp++;

                    if (loginAttemp >= 3)
                    {
                        MessageBox.Show("Bạn đã nhập sai 3 lần! Chương trình sẽ khóa toàn bộ nút.", "Khóa Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        btnLogin.Enabled = false;
                        txtPass.Enabled = false;
                        txtUser.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mã pin! Còn " + (3 - loginAttemp) + " lần thử.");
                        txtUser.Clear();
                        txtPass.Focus();
                    }
                }
            }
            catch (FormatException)
            {
                loginAttemp++;

                if (loginAttemp >= 3)
                {
                    MessageBox.Show("Bạn đã nhập sai định dạng 3 lần! Chương trình sẽ khóa toàn bộ nút.", "Khóa Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnLogin.Enabled = false;
                    txtPass.Enabled = false;
                    txtUser.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sai định dạng! Còn " + (3 - loginAttemp) + " lần thử.");
                    txtUser.Clear();
                    txtPass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
