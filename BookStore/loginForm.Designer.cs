namespace BookStore
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            lblUser = new Label();
            lblPass = new Label();
            btnLogin = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            lblTieuDe = new Label();
            tmLogin = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblUser
            // 
            resources.ApplyResources(lblUser, "lblUser");
            lblUser.Name = "lblUser";
            lblUser.Click += lblUser_Click;
            // 
            // lblPass
            // 
            resources.ApplyResources(lblPass, "lblPass");
            lblPass.Name = "lblPass";
            lblPass.Click += label2_Click;
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUser
            // 
            resources.ApplyResources(txtUser, "txtUser");
            txtUser.Name = "txtUser";
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            resources.ApplyResources(txtPass, "txtPass");
            txtPass.Name = "txtPass";
            txtPass.TextChanged += textBox2_TextChanged;
            // 
            // lblTieuDe
            // 
            resources.ApplyResources(lblTieuDe, "lblTieuDe");
            lblTieuDe.Name = "lblTieuDe";
            // 
            // tmLogin
            // 
            tmLogin.Interval = 10000;
            tmLogin.Tick += timer1_Tick;
            // 
            // loginForm
            // 
            AcceptButton = btnLogin;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTieuDe);
            Controls.Add(lblUser);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnLogin);
            Controls.Add(lblPass);
            Name = "loginForm";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private Button btnLogin;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblTieuDe;
        private System.Windows.Forms.Timer tmLogin;
    }
}
