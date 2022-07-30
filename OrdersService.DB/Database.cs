using OrdersService.DB.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.DB
{
    public class Database
    {
        private readonly string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Szymon\source\repos\OrdersService\OrdersService.DB\Data\db_OrdersService.mdf;Integrated Security = True";
        public Database()
        {

        }
        public void PopulateDB()
        {
            string queryString = "SELECT * from dbo.Orders;";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand(queryString, connection);  
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cos = reader[0];
                    }
                }
            }
        }
        public List<DBOrder> GetAllOrders()
        {
            var orders = new List<DBOrder>();
            string queryString = "SELECT Orders.Id, Orders.Name, OrderStatus.Status Name FROM dbo.Orders INNER JOIN dbo.OrderStatus ON Orders.OrderStatus = OrderStatus.Id;"; 
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new DBOrder
                        {
                            Id = (int)reader[0],
                            Name = (string)reader[1],
                            Status = (string)reader[2]
                        });
                    }
                }
            }
            return orders;
        }
    }
}
