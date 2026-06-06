using databaseKP.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace databaseKP.AddForms
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
            dtpOrderDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text) ||
                string.IsNullOrWhiteSpace(txtOrderType.Text) ||
                string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Order repo = new Order();
                repo.Add(
                    txtOrderNumber.Text.Trim(),
                    dtpOrderDate.Value.Date,
                    txtOrderType.Text.Trim(),
                    txtContent.Text.Trim()
                );

                MessageBox.Show("Приказ успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("Приказ с таким номером уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении приказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}