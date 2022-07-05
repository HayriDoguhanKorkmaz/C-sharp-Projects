using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseKullanimi
{
    public class ProductDal
    {
        //bağlantı kontrolünü her defasında yazmak yerine bir foksiyon oluşturarak gerekli yerlerde kullanıyoruz
        void connectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true;");
        public List<Product> GetAll()
        {

               
            connectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    id = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }

        public void add(Product product)
        {
            connectionControl();

            SqlCommand command = new SqlCommand(
                "Insert into Products values(@name,@UnitPrice,@StockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);

            command.ExecuteNonQuery();
            _connection.Close();

        }

        public void Update(Product product)
        {
            connectionControl();

            SqlCommand command = new SqlCommand("Update products set Name=@name, UnitPrice=@UnitPrice, StockAmount=@StockAmount where Id=@id ", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.id);

            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void delete(int id)
        {
            connectionControl();

            SqlCommand command = new SqlCommand("Delete from Products where Id=@id ", _connection);
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();

            _connection.Close();
        }


        public DataTable GetAll2()
        {


            connectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable DataTable = new DataTable();
            DataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return DataTable;
        }
    }
    
}
