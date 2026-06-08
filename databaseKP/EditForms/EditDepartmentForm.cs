using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using databaseKP.Classes;

namespace databaseKP
{
    public partial class EditDepartmentForm : Form
    {
        private readonly int _departmentId;
        private readonly string _connStr;

        public EditDepartmentForm(int departmentId)
        {
            InitializeComponent();
            _departmentId = departmentId;
            _connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadDepartmentData();
        }

        private void LoadDepartmentData()
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Departments WHERE DepartmentID = @id", conn);
                cmd.Parameters.AddWithValue("@id", _departmentId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtDepartmentName.Text = reader["DepartmentName"].ToString();
                    txtDepartmentType.Text = reader["DepartmentType"].ToString();
                }
                reader.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartmentName.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentType.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Department repo = new Department();
                repo.UpdateField(_departmentId, txtDepartmentName.Text.Trim(), txtDepartmentType.Text.Trim());

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