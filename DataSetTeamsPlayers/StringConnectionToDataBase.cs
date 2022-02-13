using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetTeamsPlayers
{
    public class StringConnectionToDataBase
    {
        public static string GetStringConnect()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();

            stringBuilder.DataSource = "DESKTOP-OCN21E3\\SQLEXPRESS";
            stringBuilder.InitialCatalog = "Football";
            stringBuilder.UserID = "kir971";
            stringBuilder.Password = "kir971";

            string connection = stringBuilder.ToString();

            return connection;
        }
    }
}
