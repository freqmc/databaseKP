using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Linq; // Добавлено для Where
using databaseKP.Classes;

namespace databaseKP
{
    public partial class AddEmployeeForm : Form
    {
        private readonly string _connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private readonly Position _posRepo = new Position();

        public AddEmployeeForm()
        {
            InitializeComponent();
            LoadPositions();
        }

        private void LoadPositions()
        {
            try
            {
                _posRepo.LoadToComboBox(cmbPosition);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки должностей: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Валидация обязательных полей
            if (string.IsNullOrWhiteSpace(txtPersonnelNumber.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtPassportSeries.Text) ||
                string.IsNullOrWhiteSpace(txtPassportNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEducation.Text) ||
                cmbPosition.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля (отмечены *).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Валидация данных
            if (txtPassportSeries.Text.Length != 4 || !int.TryParse(txtPassportSeries.Text, out _))
            {
                MessageBox.Show("Серия паспорта должна содержать 4 цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassportNumber.Text.Length != 6 || !int.TryParse(txtPassportNumber.Text, out _))
            {
                MessageBox.Show("Номер паспорта должен содержать 6 цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Employee repo = new Employee();
                repo.Add(
                    txtPersonnelNumber.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtFirstName.Text.Trim(),
                    txtMiddleName.Text.Trim(),
                    txtPassportSeries.Text.Trim(),
                    txtPassportNumber.Text.Trim(),
                    txtEducation.Text.Trim(),
                    Convert.ToInt32(cmbPosition.SelectedValue)
                );

                MessageBox.Show("Сотрудник успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException ex) when (ex.Number == 2627) // Нарушение уникальности
            {
                MessageBox.Show("Сотрудник с таким табельным номером уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении сотрудника: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPassportSeries_Leave(object sender, EventArgs e)
        {
            // Автоформатирование серии паспорта (только цифры)
            txtPassportSeries.Text = new string(txtPassportSeries.Text.Where(char.IsDigit).ToArray());
        }

        private void txtPassportNumber_Leave(object sender, EventArgs e)
        {
            // Автоформатирование номера паспорта (только цифры)
            txtPassportNumber.Text = new string(txtPassportNumber.Text.Where(char.IsDigit).ToArray());
        }
    }
}