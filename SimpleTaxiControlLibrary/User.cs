using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SimpleTaxiControlLibrary
{
    public class User
    {
        public string Name { get; set; }

        public static User GetUser(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {

                SqlCommand command = new SqlCommand("select Name from Users where login = @login and password = @password",connection);
                command.Parameters.Add(new SqlParameter("@login", login));
                command.Parameters.Add(new SqlParameter("@password", password));
                string name = command.ExecuteScalar().ToString();
                if (name != null)
                {
                    return new User
                    {
                        Name = name
                    };
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
