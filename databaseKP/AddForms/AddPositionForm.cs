using System;
using System.Windows.Forms;
using databaseKP.Classes;

namespace databaseKP.AddForms
{
    public partial class AddPositionForm : Form
    {
        private readonly Department _deptRepo = new Department();

        public AddPositionForm()
        {
            InitializeComponent();
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            try
            {
                _deptRepo.LoadToComboBox(cmbDepartment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки отделов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPositionName.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                cmbDepartment.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                MessageBox.Show("Неверный формат оклада.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Position repo = new Position();
                repo.Add(
                    txtPositionName.Text.Trim(),
                    txtCategory.Text.Trim(),
                    salary,
                    Convert.ToInt32(cmbDepartment.SelectedValue)
                );

                MessageBox.Show("Должность успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении должности: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}