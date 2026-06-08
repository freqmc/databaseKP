using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace databaseKP.Classes
{
    public class Employee
    {
        private readonly string _connStr;

        public Employee()
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
                SqlDataAdapter adapter = new SqlDataAdapter(@"
SELECT e.EmployeeID, e.PersonnelNumber, e.LastName, e.FirstName, e.MiddleName,
       e.PassportSeries, e.PassportNumber, e.Education, e.PositionID,
       p.PositionName, d.DepartmentName
FROM Employees e
LEFT JOIN Positions p ON e.PositionID = p.PositionID
LEFT JOIN Departments d ON p.DepartmentID = d.DepartmentID
ORDER BY e.LastName, e.FirstName", conn);
                adapter.Fill(dt);
                grid.DataSource = dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public void Add(string personnelNumber, string lastName, string firstName, string middleName,
            string passportSeries, string passportNumber, string education, int positionId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
INSERT INTO Employees
(PersonnelNumber, LastName, FirstName, MiddleName, PassportSeries, PassportNumber, Education, PositionID)
VALUES (@pn, @ln, @fn, @mn, @ps, @pnum, @ed, @pid)", conn);
                cmd.Parameters.AddWithValue("@pn", personnelNumber);
                cmd.Parameters.AddWithValue("@ln", lastName);
                cmd.Parameters.AddWithValue("@fn", firstName);
                cmd.Parameters.AddWithValue("@mn", string.IsNullOrWhiteSpace(middleName) ? (object)DBNull.Value : middleName);
                cmd.Parameters.AddWithValue("@ps", passportSeries);
                cmd.Parameters.AddWithValue("@pnum", passportNumber);
                cmd.Parameters.AddWithValue("@ed", education);
                cmd.Parameters.AddWithValue("@pid", positionId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public void UpdateField(int id, string personnelNumber, string lastName, string firstName, string middleName,
            string passportSeries, string passportNumber, string education, int positionId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
UPDATE Employees SET PersonnelNumber=@pn, LastName=@ln, FirstName=@fn, MiddleName=@mn,
PassportSeries=@ps, PassportNumber=@pnum, Education=@ed, PositionID=@pid
WHERE EmployeeID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pn", personnelNumber);
                cmd.Parameters.AddWithValue("@ln", lastName);
                cmd.Parameters.AddWithValue("@fn", firstName);
                cmd.Parameters.AddWithValue("@mn", string.IsNullOrWhiteSpace(middleName) ? (object)DBNull.Value : middleName);
                cmd.Parameters.AddWithValue("@ps", passportSeries);
                cmd.Parameters.AddWithValue("@pnum", passportNumber);
                cmd.Parameters.AddWithValue("@ed", education);
                cmd.Parameters.AddWithValue("@pid", positionId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
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
                    "SELECT EmployeeID, LastName + ' ' + FirstName AS FullName FROM Employees ORDER BY LastName", conn);
                adapter.Fill(dt);
                cmb.DataSource = dt;
                cmb.DisplayMember = "FullName";
                cmb.ValueMember = "EmployeeID";
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}
