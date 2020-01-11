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
        public string Login { get; private set; }

        public string Name { get; set; }

        public static User GetUser(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select Name from Users where login = @login and password = @password",connection);
                SqlParameter loginparam = new SqlParameter("@login", login);
                command.Parameters.Add(loginparam);
                command.Parameters.Add(new SqlParameter("@password", password));
                string name = command.ExecuteScalar().ToString();
                if (name != null)
                {
                    return new User
                    {
                        Login = loginparam.Value.ToString(),
                        Name = name
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public static User GetUser(string login)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select Name from Users where login = @login", connection);
                SqlParameter loginparam = new SqlParameter("@login", login);
                command.Parameters.Add(loginparam);
                string name = command.ExecuteScalar().ToString();
                if (name != null)
                {
                    return new User
                    {
                        Login = loginparam.Value.ToString(),
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
