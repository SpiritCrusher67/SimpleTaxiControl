using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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

        private SqlParameter[] GetSqlParametrs() => new SqlParameter[]
        {
            new SqlParameter("@Id", Id),

            new SqlParameter("@AddressFrom", AddressFrom),

            new SqlParameter("@NumberFrom", NumberFrom),

            new SqlParameter("@AddressTo", AddressTo),

            new SqlParameter("@NumberTo", NumberTo),

            new SqlParameter("@Date", Date),

            new SqlParameter("@Comment", Comment),

            new SqlParameter("@Status", Status),

            new SqlParameter("@CallId", Call.Id)

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

            SqlParameter idParam = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };

            string query = @"insert into Orders 
                (AddressFrom,NumberFrom,AddressTo,NumberTo,Date,Status,CallId,Comment)
                values 
                (@AddressFrom,@NumberFrom,@AddressTo,@NumberTo,@Date,@Status,@CallId,@Comment);
                set @id=SCOPE_IDENTITY()";

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(idParam);

                command.Parameters.AddRange(GetSqlParametrs());

                command.ExecuteNonQuery();
            }

            Id = (int)idParam.Value;

        }

        private void loadOrderFromDB(int id)
        {
            SqlParameter idParam = new SqlParameter("@id", id);

            string query = "select * from Orders where id = @id";

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(idParam);
            
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id = reader.GetInt32(0); 
                        AddressFrom = reader.GetString(1);
                        NumberFrom = reader.GetString(2);
                        AddressTo = reader.GetString(3);
                        NumberTo = reader.GetString(4);
                        Date = reader.GetDateTime(5);
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
            Save(query,new SqlParameter[] { new SqlParameter("@DriverId",Driver.Id), new SqlParameter("@Id", Id) });
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
            Save(query, GetSqlParametrs());
        }

        private void Save(string query,SqlParameter[] parameters)
        {

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddRange(parameters);

                command.ExecuteNonQuery();
            }
        }
    }
}
