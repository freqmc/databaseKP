using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using databaseKP.Utils;

namespace databaseKP
{
    public partial class RegisterForm : Form
    {
        private readonly string _connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public RegisterForm()
        {
            InitializeComponent();
            // Заполняем комбобокс ролями (только Гость и Кадровик)
            cmbRole.Items.AddRange(new object[] { "Гость", "Кадровик" });
            cmbRole.SelectedIndex = 0; // По умолчанию Гость
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Валидация полей
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Хешируем пароль перед сохранением
            string hashedPassword = PasswordCrypt.HashPassword(txtPassword.Text);

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                // SQL запрос на вставку
                string query = @"INSERT INTO Users (LoginName, PasswordText, FullName, RoleName) 
                                 VALUES (@login, @pass, @full, @role)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", hashedPassword);
                    cmd.Parameters.AddWithValue("@full", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Регистрация прошла успешно! Теперь вы можете войти.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        // Код ошибки 2627 означает нарушение уникального ограничения (логин занят)
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существует. Выберите другой логин.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка базы данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}