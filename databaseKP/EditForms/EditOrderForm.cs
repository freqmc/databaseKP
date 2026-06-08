using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using databaseKP.Classes;

namespace databaseKP
{
    public partial class EditOrderForm : Form
    {
        private readonly int _orderId;
        private readonly string _connStr;

        public EditOrderForm(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            _connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE OrderID = @id", conn);
                cmd.Parameters.AddWithValue("@id", _orderId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtOrderNumber.Text = reader["OrderNumber"].ToString();
                    dtpOrderDate.Value = Convert.ToDateTime(reader["OrderDate"]);
                    txtOrderType.Text = reader["OrderType"].ToString();
                    txtContent.Text = reader["Content"].ToString();
                }
                reader.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text) ||
                string.IsNullOrWhiteSpace(txtOrderType.Text) ||
                string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Order repo = new Order();
                repo.UpdateField(_orderId, txtOrderNumber.Text.Trim(), dtpOrderDate.Value.Date, txtOrderType.Text.Trim(), txtContent.Text.Trim());

                MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}