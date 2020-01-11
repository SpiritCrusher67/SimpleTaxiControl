using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SimpleTaxiControlLibrary
{
     public class Driver
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Name { get; set; }

        public DriverStatuses Status { get; set; }

        public Driver(int id)
        {
            LoadDriverFromDB(id);
        }

        private void LoadDriverFromDB(int id)
        {
            SqlParameter idparam = new SqlParameter("@id", id);

            string query = "select * from Drivers where id = @id";

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(idparam);

                using (SqlDataReader reader = command.ExecuteReader())
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

    }
}
