using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory
{

    public class InventoryQuery
    {
        private SqlConnection sqlConnect;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        private SqlCommand sqlCommand;
        public DataTable dataTable;
        public BindingSource bindingSource;

        private string connectionString;
       
        public InventoryQuery() 
        {
            connectionString = @"Data Source=LAPTOP-NHOM4IUH\SQLEXPRESS;Initial Catalog=ProductInventoryDB;Integrated Security=True";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayProduct()
        {
            try
            {
                string selectQuery = "SELECT * FROM ProductInvertory";
                sqlConnect.Open();
                sqlAdapter = new SqlDataAdapter(selectQuery, sqlConnect);
                dataTable.Clear();

                sqlAdapter.Fill(dataTable);
                bindingSource.DataSource = dataTable;

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                sqlConnect.Close();
            }
        }


        public bool AddProduct(string productName, string category, string mfgDate, string expDate, double price, int quantity, string description)
        {
            try
            {
                sqlConnect.Open();
                string query = "INSERT INTO ProductInvertory (ProductName, Category, ManufacturingDate, ExpirationDate, Quantity, SellingPrice, Description) " +
                               "VALUES (@ProductName, @Category, @MfgDate, @ExpDate, @Quantity, @SellingPrice, @Description)";
                sqlCommand = new SqlCommand(query, sqlConnect);
                sqlCommand.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = productName;
                sqlCommand.Parameters.Add("@Category", SqlDbType.VarChar).Value = category;
                sqlCommand.Parameters.Add("@MfgDate", SqlDbType.Date).Value = mfgDate;
                sqlCommand.Parameters.Add("@ExpDate", SqlDbType.Date).Value = expDate;
                sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                sqlCommand.Parameters.Add("@SellingPrice", SqlDbType.Float).Value = price;
                sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;
                int result = sqlCommand.ExecuteNonQuery();
                return result > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                sqlConnect.Close();
            }
        }

    }
}
