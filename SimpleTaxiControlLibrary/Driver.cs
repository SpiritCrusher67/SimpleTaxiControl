using System.Data.SQLite;

namespace SimpleTaxiControlLibrary
{
     public class Driver
     {

        public int Id { get; set; }

        public string Model { get; set; }

        public string Name { get; set; }

        public DriverStatuses Status { get; set; }

        private SQLiteParameter[] GetSqlParametrs() => new SQLiteParameter[]
        {
            new SQLiteParameter("@Id",Id),

            new SQLiteParameter("@Model",Model),

            new SQLiteParameter("@Name",Name),

            new SQLiteParameter("@Status",Status)
        };

        public Driver(int id)
        {
            LoadDriverFromDB(id);
        }

        private void LoadDriverFromDB(int id)
        {
            SQLiteParameter idparam = new SQLiteParameter("@id", id);

            string query = "select * from Drivers where id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.Add(idparam);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id = reader.GetInt32(0);

                        Model = reader.GetString(1);

                        Name = reader.GetString(2);

                        Status = (DriverStatuses)reader.GetInt32(3);
                    }
                }
            }
        }

        public void SaveChanges()
        {
            string query = @"update Drivers set 
                Model = @Model,
                Name = @Name,
                Status = @Status
                where Id = @Id";

            using (SQLiteConnection connection = new SQLiteConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.AddRange(GetSqlParametrs());

                command.ExecuteNonQuery();
            }
        }

        public static int SaveDriverInDb(string name, string model)
        {
            int rowsInvolved = 0;
            string query = "insert into Drivers (Name,Model,Status) values (@Name,@Model,@Status)";

            using (SQLiteConnection connection = new SQLiteConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter("@Name",name),
                    new SQLiteParameter("@Model",model),
                    new SQLiteParameter("@Status",DriverStatuses.Free)

                });
                try { rowsInvolved = command.ExecuteNonQuery(); }
                catch { }

                return rowsInvolved;
            }
        }
    }
}
