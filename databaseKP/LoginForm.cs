using databaseKP;
using databaseKP.Utils;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace databaseKP
{
    public partial class LoginForm : Form
    {
        private readonly string _connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                string query = "SELECT UserID, LoginName, FullName, RoleName, PasswordText FROM Users WHERE LoginName = @login";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["PasswordText"].ToString();
                            if (PasswordCrypt.VerifyPassword(txtPassword.Text, storedHash))
                            {
                                SessionManager.UserId = Convert.ToInt32(reader["UserID"]);
                                SessionManager.Login = reader["LoginName"].ToString();
                                SessionManager.FullName = reader["FullName"].ToString();
                                SessionManager.Role = reader["RoleName"].ToString();

                                this.Hide();
                                MainForm mainForm = new MainForm();
                                mainForm.FormClosed += (s, args) => this.Close();
                                mainForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            if (regForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Регистрация успешна. Теперь вы можете войти.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}