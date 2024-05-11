using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class Connection
    {
        public static string getCadenaConexion()
        {
            string connectionString = "Data Source=LAB1504-16\\SQLEXPRESS;Initial Catalog=FacturaDB;User Id=user01;Password=12345678";
            return connectionString;
        }
    }
}
