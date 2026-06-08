using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using databaseKP.Classes;

namespace databaseKP
{
    public partial class EditPositionForm : Form
    {
        private readonly int _positionId;
        private readonly string _connStr;

        public EditPositionForm(int positionId)
        {
            InitializeComponent();
            _positionId = positionId;
            _connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadPositionData();
            LoadDepartments();
        }

        private void LoadPositionData()
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Positions WHERE PositionID = @id", conn);
                cmd.Parameters.AddWithValue("@id", _positionId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtPositionName.Text = reader["PositionName"].ToString();
                    txtCategory.Text = reader["Category"].ToString();
                    txtSalary.Text = reader["Salary"].ToString();
                }
                reader.Close();
            }
        }

        private void LoadDepartments()
        {
            Department repo = new Department();
            repo.LoadToComboBox(cmbDepartment);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPositionName.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                !decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                MessageBox.Show("Заполните все поля корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Position repo = new Position();
                repo.UpdateField(_positionId, txtPositionName.Text.Trim(), txtCategory.Text.Trim(), salary, Convert.ToInt32(cmbDepartment.SelectedValue));

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