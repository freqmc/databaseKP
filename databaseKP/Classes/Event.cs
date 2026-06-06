using System.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace databaseKP.Classes
{
    public class Event
    {
        private readonly string _connStr;

        public Event()
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
SELECT se.EventID, se.EventType, se.EventDate, se.Basis,
       se.EmployeeID, e.LastName + ' ' + e.FirstName AS EmployeeName,
       se.OrderID, o.OrderNumber,
       se.PositionID, p.PositionName
FROM StaffEvents se
LEFT JOIN Employees e ON se.EmployeeID = e.EmployeeID
LEFT JOIN Orders o ON se.OrderID = o.OrderID
LEFT JOIN Positions p ON se.PositionID = p.PositionID
ORDER BY se.EventDate DESC", conn);
                adapter.Fill(dt);
                grid.DataSource = dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public void Add(string type, DateTime date, string basis, int employeeId, int orderId, int positionId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO StaffEvents (EventType, EventDate, Basis, EmployeeID, OrderID, PositionID) VALUES (@t, @d, @b, @e, @o, @p)", conn);
                cmd.Parameters.AddWithValue("@t", type);
                cmd.Parameters.AddWithValue("@d", date.Date);
                cmd.Parameters.AddWithValue("@b", basis);
                cmd.Parameters.AddWithValue("@e", employeeId);
                cmd.Parameters.AddWithValue("@o", orderId);
                cmd.Parameters.AddWithValue("@p", positionId);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM StaffEvents WHERE EventID=@id", conn);
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

        public void LoadOrderComboBox(ComboBox cmb)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT OrderID, OrderNumber FROM Orders ORDER BY OrderNumber", conn);
                adapter.Fill(dt);
                cmb.DataSource = dt;
                cmb.DisplayMember = "OrderNumber";
                cmb.ValueMember = "OrderID";
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public void LoadPositionComboBox(ComboBox cmb)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT PositionID, PositionName FROM Positions ORDER BY PositionName", conn);
                adapter.Fill(dt);
                cmb.DataSource = dt;
                cmb.DisplayMember = "PositionName";
                cmb.ValueMember = "PositionID";
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}
