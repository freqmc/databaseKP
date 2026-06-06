using System;
using System.Windows.Forms;
using databaseKP.Classes;

namespace databaseKP.AddForms
{
    public partial class AddTimesheetForm : Form
    {
        private readonly Employee _empRepo = new Employee();

        public AddTimesheetForm()
        {
            InitializeComponent();
            LoadEmployees();
            dtpRecordDate.Value = DateTime.Now;
        }

        private void LoadEmployees()
        {
            try
            {
                _empRepo.LoadToComboBox(cmbEmployee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки сотрудников: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtAttendanceCode.Text) ||
                !decimal.TryParse(txtHours.Text, out decimal hours))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Timesheet repo = new Timesheet();
                repo.Add(
                    dtpRecordDate.Value.Date,
                    txtAttendanceCode.Text.Trim().ToUpper(),
                    hours,
                    Convert.ToInt32(cmbEmployee.SelectedValue)
                );

                MessageBox.Show("Запись в табель успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении записи: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}