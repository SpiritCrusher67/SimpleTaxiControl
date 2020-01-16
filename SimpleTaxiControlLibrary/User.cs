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

        public UserTypes Type { get; set; }

        public static User GetUser(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select Name, Type from Users where login = @login and password = @password",connection);
                SqlParameter loginparam = new SqlParameter("@login", login);
                command.Parameters.Add(loginparam);
                command.Parameters.Add(new SqlParameter("@password", password));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Login = loginparam.Value.ToString(),
                            Name = reader.GetString(0),
                            Type = (UserTypes)reader.GetValue(1)
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static User GetUser(string login)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select Name, Type from Users where login = @login", connection);
                SqlParameter loginparam = new SqlParameter("@login", login);
                command.Parameters.Add(loginparam);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Login = loginparam.Value.ToString(),
                            Name = reader.GetString(0),
                            Type = (UserTypes)reader.GetValue(1)
                        };
                    }
                    else
                    {
                        return null;
                    }
                }

            }
        }

        public static List<User> GetAllUsersFromDB()
        {
            List<string> logins = new List<string>();

            List<User> users = new List<User>();

            string query = "select Login from Users";

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                using (SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        logins.Add(reader.GetString(0));
                    }
                }
            }

            foreach (string login in logins)
            {
                users.Add(GetUser(login));
            }

            return users;
        }

        public static int SaveUserInDb(string login, string password, string name, UserTypes type = UserTypes.Dispatcher)
        {
            int rowsInvolved = 0;
            string query = "insert into Users (Login,Password,Name,Type) values (@Login,@Password,@Name,@Type)";

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query,connection);

                command.Parameters.AddRange(new SqlParameter[]
                {
                    new SqlParameter("@Login",login),
                    new SqlParameter("@Password",password),
                    new SqlParameter("@Name",name),
                    new SqlParameter("@Type",type)

                });
                try { rowsInvolved = command.ExecuteNonQuery(); }
                catch { }

                return rowsInvolved;
            }
        }

        public static string GetRandomPassword(int symbols)
        {
            string password = "";

            Random random = new Random();

            for (int i = 0; i < symbols; i++)
            {
                password += char.ConvertFromUtf32(random.Next(48, 122));
            }

            return password;
        }

        public static string GetUserPassword(string login,User user)
        {
            if (user.Type == UserTypes.Admin)
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("select Password from Users where Login = @Login",connection);

                    command.Parameters.Add(new SqlParameter("@Login", login));

                    return command.ExecuteScalar().ToString();
                }
            }
            else return null;
        }
    }
}
