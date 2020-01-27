using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

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
            SQLiteParameter numberparam = new SQLiteParameter("@Number", Number);

            SQLiteParameter loginParam = new SQLiteParameter("@UserLogin", ResponsibleUser.Login);

            SQLiteParameter dateparam = new SQLiteParameter("@Date", DateTime.Now.ToString());

            string query = "insert into Calls (Number,UserLogin,Date) values (@Number,@UserLogin,@Date);SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.AddRange(new SQLiteParameter[] { numberparam, loginParam,dateparam});

                Id = int.Parse(command.ExecuteScalar().ToString());
            }

        }

        private void LoadCallFromDB(int id)
        {
            SQLiteParameter idParam = new SQLiteParameter("@id", id);

            string query = "select * from Calls where id = @id";

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
                        Number = reader.GetString(1);
                        ResponsibleUser = User.GetUser(reader.GetString(2));
                        Date = DateTime.Parse(reader.GetString(3));
                    }
                }
            }
        }

        public static List<Call> GetAllCallsFromDB()
        {
            List<int> ids = new List<int>();

            List<Call> calls = new List<Call>();

            string query = "select Id from Calls";

            using (SQLiteConnection connection = new SQLiteConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                using (SQLiteDataReader reader = new SQLiteCommand(query, connection).ExecuteReader())
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
