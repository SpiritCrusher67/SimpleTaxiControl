using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaxiControlLibrary
{
    public static class OnlineDrivers
    {
        private static List<Driver> _driversList;

        public static List<Driver> DriversList
        {
            get
            {
                if (_driversList == null)
                {
                    _driversList = new List<Driver>();

                    LoadActiveDrivers();
                }

                return _driversList;
            }

            set => _driversList = value;
        }

        private static void LoadActiveDrivers()
        {
            string query = $@"select id from Drivers 
                where Status != '{(int)OrderStatuses.Сompleted}'";

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DriversList.Add(new Driver(reader.GetInt32(0)));
                    }
                }
            }
        }

        public static List<Driver> GetOnlineDrivers() => DriversList.Where(d => d.Status != DriverStatuses.Offline).ToList();

        public static List<Driver> GetFreeDrivers() => DriversList.Where(d => d.Status == DriverStatuses.Free).ToList();

    }
}
