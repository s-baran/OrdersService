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

        public void CreateStatus(string status)
        {
            string queryString = $"INSERT INTO OrderStatus (Status) VALUES ('{status}')";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public List<DBItem> GetAllItems()
        {
            var items = new List<DBItem>();
            string queryString = "SELECT Items.Id, Items.Name, Items.Price FROM dbo.Items";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new DBItem
                        {
                            Id = (int)reader[0],
                            Name = (string)reader[1],
                            Price = (decimal)reader[2],
                        });
                    }
                }
            }
            return items;
        }

        public int GetStatusID(string orderStatus)
        {
            string queryString = $"SELECT OrderStatus.Id, OrderStatus.Status FROM dbo.OrderStatus WHERE Status = '{orderStatus}'";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return (int)reader[0];
                    else
                        return -1;
                }
            }
        }

        public int CreateNewOrder(DBNewOrder newOrder)
        {
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append("INSERT INTO Orders (Name, OrderStatusId, CustomerId) ");
            queryBuilder.Append("OUTPUT INSERTED.Id ");
            queryBuilder.Append("VALUES ");
            queryBuilder.Append($"('{newOrder.Name}', '{newOrder.OrderStatusId}', '{newOrder.CustomerId}')");
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand(queryBuilder.ToString(), connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return (int)reader[0];
                    }
                }
            }
            return -1;
        }
        public bool CreateOrderItems(List<DBOrderItem> newOrderItem)
        {
            if (newOrderItem.Count == 0)
                return true;
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append("INSERT INTO OrderItems (OrderId, ItemId, Quantity) ");
            queryBuilder.Append("VALUES ");
            foreach (DBOrderItem item in newOrderItem)
            {
                queryBuilder.Append($"('{item.OrderId}', '{item.ItemId}', '{item.Quantity}'), ");
            }
            queryBuilder.Remove(queryBuilder.Length-2, 1);
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand(queryBuilder.ToString(), connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            return true;
        }

        public void RemoveOrder(int orderId)
        {
            string deleteOrderItemsQueryString = $"DELETE FROM OrderItems WHERE OrderId = '{orderId}'";
            string deleteOrderQueryString = $"DELETE FROM Orders WHERE Id = '{orderId}'";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var deleteItemsCommand = new SqlCommand(deleteOrderItemsQueryString, connection);
                var deleteOrderCommand = new SqlCommand(deleteOrderQueryString, connection);
                connection.Open();
                deleteItemsCommand.ExecuteNonQuery();
                deleteOrderCommand.ExecuteNonQuery();
            }
        }

        public int CreateCustomer(DBCustomer newCustomer)
        {
            string searchQuery = $"SELECT Id FROM Customers WHERE FirstName='{newCustomer.FirstName}' AND LastName='{newCustomer.LastName}'";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand(searchQuery, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return (int)reader[0];
                    }
                }
            }

            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append("INSERT INTO Customers (FirstName, LastName, PhoneNumber, Address) ");
            queryBuilder.Append("OUTPUT INSERTED.Id ");
            queryBuilder.Append("VALUES ");
            queryBuilder.Append($"('{newCustomer.FirstName}', '{newCustomer.LastName}', '{newCustomer.PhoneNumber}', '{newCustomer.Address}')");
            
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand(queryBuilder.ToString(), connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return (int)reader[0];
                    }
                } 
            }

            return -1;
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
            string queryString = "SELECT Orders.Id, Orders.Name, OrderStatus.Status, Orders.CreationTime FROM dbo.Orders INNER JOIN dbo.OrderStatus ON Orders.OrderStatusId = OrderStatus.Id";
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
