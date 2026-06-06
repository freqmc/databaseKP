namespace databaseKP
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(30, 30);
            this.lblLogin.Text = "Логин:";

            this.txtLogin.Location = new System.Drawing.Point(30, 50);
            this.txtLogin.Size = new System.Drawing.Size(240, 23);

            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 90);
            this.lblPassword.Text = "Пароль:";

            this.txtPassword.Location = new System.Drawing.Point(30, 110);
            this.txtPassword.Size = new System.Drawing.Size(240, 23);
            this.txtPassword.PasswordChar = '*';

            this.btnLogin.Location = new System.Drawing.Point(30, 160);
            this.btnLogin.Size = new System.Drawing.Size(110, 30);
            this.btnLogin.Text = "Войти";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.btnRegister.Location = new System.Drawing.Point(160, 160);
            this.btnRegister.Size = new System.Drawing.Size(110, 30);
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему 'Отдел кадров'";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}