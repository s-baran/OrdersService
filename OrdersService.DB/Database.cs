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

        public DBOrderDetails GetOrderDetails(int requestId)
        {
            var orderDetails = new DBOrderDetails();
            var items = new List<DBOrderItem>();
            var customer = new DBCustomer();

            string getOrderItemsQueryString = $"SELECT OrderItems.ItemId, Items.Name, Items.Price, OrderItems.Quantity FROM OrderItems INNER JOIN Items ON OrderId = '{requestId}' AND ItemId = Items.Id";
            string getCustomerQueryString = $"SELECT Customers.Id, Customers.FirstName, Customers.LastName, Customers.PhoneNumber, Customers.Address FROM Customers JOIN Orders ON Orders.Id = '{requestId}' and Orders.CustomerId = Customers.Id";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var getOrdersCommand = new SqlCommand(getOrderItemsQueryString, connection);
                var getCustomerCommand = new SqlCommand(getCustomerQueryString, connection);
                connection.Open();
                using (SqlDataReader reader = getOrdersCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new DBOrderItem
                        {
                            ItemId = (int)reader[0],
                            Name = (string)reader[1],
                            Price = (decimal)reader[2],
                            Quantity = (int)reader[3]
                        });
                    }
                }
                using (SqlDataReader reader = getCustomerCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customer = new DBCustomer
                        {
                            Id = (int)reader[0],
                            FirstName = (string)reader[1],
                            LastName = (string)reader[2],
                            PhoneNumber = (string)reader[3],
                            Address = (string)reader[4],
                        };
                    }
                }
            }

            orderDetails.Items = items;
            orderDetails.CustomerDetails = customer;

            return orderDetails;
        }

        public List<DBOrder> GetAllOrders()
        {
            var orders = new List<DBOrder>();
            string queryString = "SELECT Orders.Id, Orders.Name, OrderStatus.Status, Order.CreationTime FROM dbo.Orders INNER JOIN dbo.OrderStatus ON Orders.OrderStatusId = OrderStatus.Id;";
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
                            Status = (string)reader[2],
                            CreationTime = (DateTime)reader[3]
                        });
                    }
                }
            }
            return orders;
        }
    }
}
