using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using databaseKP.Classes;

namespace databaseKP
{
    public partial class EditEmployeeForm : Form
    {
        private readonly int _employeeId;
        private readonly string _connStr;

        public EditEmployeeForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            _connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadEmployeeData();
            LoadPositions();
        }

        private void LoadEmployeeData()
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE EmployeeID = @id", conn);
                cmd.Parameters.AddWithValue("@id", _employeeId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtPersonnelNumber.Text = reader["PersonnelNumber"].ToString();
                    txtLastName.Text = reader["LastName"].ToString();
                    txtFirstName.Text = reader["FirstName"].ToString();
                    txtMiddleName.Text = reader["MiddleName"].ToString();
                    txtPassportSeries.Text = reader["PassportSeries"].ToString();
                    txtPassportNumber.Text = reader["PassportNumber"].ToString();
                    txtEducation.Text = reader["Education"].ToString();
                }
                reader.Close();
            }
        }

        private void LoadPositions()
        {
            Position repo = new Position();
            repo.LoadToComboBox(cmbPosition);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPersonnelNumber.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Заполните обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Employee repo = new Employee();
                repo.UpdateField(
                    _employeeId,
                    txtPersonnelNumber.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtFirstName.Text.Trim(),
                    txtMiddleName.Text.Trim(),
                    txtPassportSeries.Text.Trim(),
                    txtPassportNumber.Text.Trim(),
                    txtEducation.Text.Trim(),
                    Convert.ToInt32(cmbPosition.SelectedValue)
                );

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