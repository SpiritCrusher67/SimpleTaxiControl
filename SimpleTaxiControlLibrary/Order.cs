using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Data;

namespace SimpleTaxiControlLibrary
{
    public class Order
    {
        public string AddressFrom { get; set; }

        public string NumberFrom { get; set; }

        public string AddressTo { get; set; }

        public string NumberTo { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public OrderStatuses Status { get; set; }

        public Call Call { get; set; }

        public int Id { get; private set; }

        public Driver Driver { get; set; }

        private SQLiteParameter[] GetSQLiteParametrs() => new SQLiteParameter[]
        {
            new SQLiteParameter("@Id", Id),

            new SQLiteParameter("@AddressFrom", AddressFrom),

            new SQLiteParameter("@NumberFrom", NumberFrom),

            new SQLiteParameter("@AddressTo", AddressTo),

            new SQLiteParameter("@NumberTo", NumberTo),

            new SQLiteParameter("@Date", Date),

            new SQLiteParameter("@Comment", Comment),

            new SQLiteParameter("@Status", Status),

            new SQLiteParameter("@CallId", Call.Id)

        }; 


        public Order(string addressFrom, string numberFrom, string addressTo, string numberTo, DateTime date, string comment, Call call)
        {
            AddressFrom = addressFrom;

            NumberFrom = numberFrom;

            AddressTo = addressTo;

            NumberTo = numberTo;

            Date = date;

            Comment = comment;

            Status = OrderStatuses.Free;

            Call = call;

            SaveOrder();
        }

        public Order(int id)
        {
            loadOrderFromDB(id);
        }



        private void SaveOrder()
        {

            string query = @"insert into Orders 
                (AddressFrom,NumberFrom,AddressTo,NumberTo,Date,Status,CallId,Comment)
                values 
                (@AddressFrom,@NumberFrom,@AddressTo,@NumberTo,@Date,@Status,@CallId,@Comment);
                SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.AddRange(GetSQLiteParametrs());

                Id = int.Parse(command.ExecuteScalar().ToString());
            }

        }

        private void loadOrderFromDB(int id)
        {
            SQLiteParameter idParam = new SQLiteParameter("@id", id);

            string query = "select * from Orders where id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.Add(idParam);
            
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id = reader.GetInt32(0); 
                        AddressFrom = reader.GetString(1);
                        NumberFrom = reader.GetString(2);
                        AddressTo = reader.GetString(3);
                        NumberTo = reader.GetString(4);
                        Date = DateTime.Parse(reader.GetString(5));
                        Status = (OrderStatuses)reader.GetInt32(6);
                        Call = new Call(reader.GetInt32(7));
                        Comment = reader.GetValue(8).ToString();
                        Driver = (reader.GetValue(9).ToString() != string.Empty) ? new Driver(reader.GetInt32(9)) : null;

                    }
                }
            }
        }

        public void SaveDriver()
        {
            string query = @"update Orders set 
                DriverId = @DriverId
                where Id = @Id";
            Save(query,new SQLiteParameter[] { new SQLiteParameter("@DriverId",Driver.Id), new SQLiteParameter("@Id", Id) });
        }

        public void SaveChanges()
        {
            string query = @"update Orders set 
                AddressFrom = @AddressFrom,
                NumberFrom = @NumberFrom,
                AddressTo = @AddressTo,
                NumberTo = @NumberTo,
                Date = @Date,
                Status = @Status,
                CallId = @CallId,
                Comment = @Comment
                where Id = @Id";
            Save(query, GetSQLiteParametrs());
        }

        private void Save(string query,SQLiteParameter[] parameters)
        {

            using (SQLiteConnection connection = new SQLiteConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.AddRange(parameters);

                command.ExecuteNonQuery();
            }
        }

        private static List<Order> GetOrders()
        {
            string query = $@"select id from Orders";
            List<Order> orders = new List<Order>();

            using (SQLiteConnection connection = new SQLiteConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order(reader.GetInt32(0)));
                    }
                }
            }
            return orders;
        }

        public static List<Order> GetFreeOrders() => GetOrders().Where(o => o.Status == OrderStatuses.Free).ToList();

        public static List<Order> GetAcceptedOrders() => GetOrders().Where(o => o.Status == OrderStatuses.Accepted).ToList();

        public static List<Order> GetInProgressOrders() => GetOrders().Where(o => o.Status == OrderStatuses.InProgress).ToList();

        public static List<Order> GetAllOrders() => GetOrders();
    }
}
