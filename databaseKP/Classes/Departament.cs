using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace databaseKP.Classes
{
    public class Department
    {
        private readonly string _connStr;

        public Department()
        {
            _connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void DisplayData(DataGridView grid)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Departments ORDER BY DepartmentID", conn);
                adapter.Fill(dt);
                grid.DataSource = dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void Add(string name, string type)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Departments (DepartmentName, DepartmentType) VALUES (@n, @t)", conn);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@t", type);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void Update(int id, string name, string type)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Departments SET DepartmentName=@n, DepartmentType=@t WHERE DepartmentID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@t", type);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Departments WHERE DepartmentID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void LoadToComboBox(ComboBox cmb)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT DepartmentID, DepartmentName FROM Departments ORDER BY DepartmentName", conn);
                adapter.Fill(dt);
                cmb.DataSource = dt;
                cmb.DisplayMember = "DepartmentName";
                cmb.ValueMember = "DepartmentID";
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
