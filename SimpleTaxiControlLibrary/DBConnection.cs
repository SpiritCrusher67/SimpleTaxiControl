using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaxiControlLibrary
{
    public static class DBConnection
    {
        public static string ConnectionString { get; set; } = @"Data Source=DESKTOP-O01TIT6\SQLEXPRESS;Initial Catalog=SimpleTaxiControlDB;Integrated Security=True";


    }
}
