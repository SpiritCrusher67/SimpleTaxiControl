using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SimpleTaxiControlLibrary
{
    public class Call
    {
        public int Id { get; private set; }

        public string Number { get; set; }

        public User ResponsibleUser  { get; set; }

        public DateTime Date { get; set; }

        public Call(string number, User user)
        {
            Number = number;
            ResponsibleUser = user;
            Date = DateTime.Now;
            SaveCall();
        }

        public Call(int id)
        {
            LoadCallFromDB(id);
        }

        public void SaveCall()
        {
            SqlParameter numberparam = new SqlParameter("@Number", Number);

            SqlParameter loginParam = new SqlParameter("@UserLogin", ResponsibleUser.Login);

            SqlParameter dateparam = new SqlParameter("@Date", DateTime.Now);

            SqlParameter idParam = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };

            string query = "insert into Calls (Number,UserLogin,Date) values (@Number,@UserLogin,@Date);set @id=SCOPE_IDENTITY()";

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddRange(new SqlParameter[] { numberparam, loginParam,dateparam,idParam});

                command.ExecuteNonQuery();
            }

            Id = (int)idParam.Value;
        }

        private void LoadCallFromDB(int id)
        {
            SqlParameter idParam = new SqlParameter("@id", id);

            string query = "select * from Calls where id = @id";

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
                        Number = reader.GetString(1);
                        ResponsibleUser = User.GetUser(reader.GetString(2));
                        Date = reader.GetDateTime(3);
                    }
                }
            }
        }

        public static List<Call> GetAllCallsFromDB()
        {
            List<int> ids = new List<int>();

            List<Call> calls = new List<Call>();

            string query = "select Id from Calls";

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                using (SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add(reader.GetInt32(0));
                    }
                }
            }

            foreach (int id in ids)
            {
                calls.Add(new Call(id));
            }

            return calls;
        }
    }
}
