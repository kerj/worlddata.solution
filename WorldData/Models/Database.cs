using System;
using MySql.Data.MySqlClient;
using WorldData.Models;

namespace WorldData.Models
{

    public class DB
    {

      public static MySqlConnection Connection()
      {
          MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
          return conn;
      }

    }

}
