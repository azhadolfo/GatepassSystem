using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestingPhase
{
    internal class rootVariable
    {
        public static string ConnectionString { get; set; } = "Data Source=WIN-IU3ACLEQUUI;Initial Catalog=cs_crud;Persist Security Info=True;User ID=user3;Password=twainc.";

        public static SqlConnection SqlConnection { get; set; } = new SqlConnection(ConnectionString);

       //public static string CONNECTION_STR {  get; set; } = "Data Source=WIN-IU3ACLEQUUI;Initial Catalog=cs_crud;Persist Security Info=True;User ID=user3;Password=twainc.";

    }
}
