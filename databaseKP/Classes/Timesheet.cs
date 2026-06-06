using System.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace databaseKP.Classes
{
    public class Timesheet
    {
        private readonly string _connStr;

        public Timesheet()
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
SELECT t.TimesheetID, t.RecordDate, t.AttendanceCode, t.Hours,
       t.EmployeeID, e.LastName + ' ' + e.FirstName AS EmployeeName
FROM TimesheetRecords t
LEFT JOIN Employees e ON t.EmployeeID = e.EmployeeID
ORDER BY t.RecordDate DESC", conn);
                adapter.Fill(dt);
                grid.DataSource = dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public void Add(DateTime date, string attendanceCode, decimal hours, int employeeId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO TimesheetRecords (RecordDate, AttendanceCode, Hours, EmployeeID) VALUES (@d, @a, @h, @e)", conn);
                cmd.Parameters.AddWithValue("@d", date.Date);
                cmd.Parameters.AddWithValue("@a", attendanceCode);
                cmd.Parameters.AddWithValue("@h", hours);
                cmd.Parameters.AddWithValue("@e", employeeId);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM TimesheetRecords WHERE TimesheetID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public void LoadEmployeeComboBox(ComboBox cmb)
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
