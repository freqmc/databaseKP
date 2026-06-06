using System;
using System.Windows.Forms;
using databaseKP.Classes;

namespace databaseKP.AddForms
{
    public partial class AddEventForm : Form
    {
        private readonly Employee _empRepo = new Employee();
        private readonly Order _orderRepo = new Order();
        private readonly Position _posRepo = new Position();

        public AddEventForm()
        {
            InitializeComponent();
            LoadEmployees();
            LoadOrders();
            LoadPositions();
            dtpEventDate.Value = DateTime.Now;
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

        private void LoadOrders()
        {
            try
            {
                _orderRepo.LoadToComboBox(cmbOrder);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки приказов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (cmbEmployee.SelectedValue == null ||
                cmbOrder.SelectedValue == null ||
                cmbPosition.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtEventType.Text) ||
                string.IsNullOrWhiteSpace(txtBasis.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Event repo = new Event();
                repo.Add(
                    txtEventType.Text.Trim(),
                    dtpEventDate.Value.Date,
                    txtBasis.Text.Trim(),
                    Convert.ToInt32(cmbEmployee.SelectedValue),
                    Convert.ToInt32(cmbOrder.SelectedValue),
                    Convert.ToInt32(cmbPosition.SelectedValue)
                );

                MessageBox.Show("Кадровое событие успешно добавлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении события: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}