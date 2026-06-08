using System.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace databaseKP.Classes
{
    public class Order
    {
        private readonly string _connStr;

        public Order()
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Orders ORDER BY OrderDate DESC", conn);
                adapter.Fill(dt);
                grid.DataSource = dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public void Add(string number, DateTime date, string type, string content)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Orders (OrderNumber, OrderDate, OrderType, Content) VALUES (@n, @d, @t, @c)", conn);
                cmd.Parameters.AddWithValue("@n", number);
                cmd.Parameters.AddWithValue("@d", date.Date);
                cmd.Parameters.AddWithValue("@t", type);
                cmd.Parameters.AddWithValue("@c", content);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public void UpdateField(int id, string number, DateTime date, string type, string content)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Orders SET OrderNumber=@n, OrderDate=@d, OrderType=@t, Content=@c WHERE OrderID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@n", number);
                cmd.Parameters.AddWithValue("@d", date.Date);
                cmd.Parameters.AddWithValue("@t", type);
                cmd.Parameters.AddWithValue("@c", content);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Orders WHERE OrderID=@id", conn);
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
    }
}
