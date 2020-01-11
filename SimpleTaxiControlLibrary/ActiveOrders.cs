using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SimpleTaxiControlLibrary
{
    public static class ActiveOrders
    {
        private static List<Order> _ordersList;

        public static List<Order> OrdersList
        {
            get
            {
                if (_ordersList == null)
                {
                    _ordersList = new List<Order>();

                    LoadActiveOrders();
                }


                return _ordersList;
            }

            set => _ordersList = value;
        }

        private static void LoadActiveOrders()
        {
            string query = $@"select id from Orders 
                where Status != '{(int)OrderStatuses.Сompleted}'";

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrdersList.Add(new Order(reader.GetInt32(0)));
                    }
                }
            }
        }

        public static List<Order> GetFreeOrders() => OrdersList.Where(o => o.Status == (int)OrderStatuses.Free).ToList();

        public static List<Order> GetAcceptedOrders() => OrdersList.Where(o => o.Status == (int)OrderStatuses.Accepted).ToList();

        public static List<Order> GetInProgressOrders() => OrdersList.Where(o => o.Status == (int)OrderStatuses.InProgress).ToList();

        public static List<Order> GetAllOrders() => OrdersList;


    }
}
