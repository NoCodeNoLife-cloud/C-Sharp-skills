using System;
using MySql.Data.MySqlClient;

namespace open_mysql_database
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string connStr = "server = localhost; user = root; database = world; port = 3306; password = 123456";
            MySqlConnection conn = new MySqlConnection(connStr) ;
            try{conn.Open();}
            catch(Exception ex){Console.WriteLine(ex.ToString());}
            string sql = "SELECT * from writer;" ;
            MySqlCommand cmd = new MySqlCommand(sql, conn) ;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                Console.WriteLine(rdr[0] + " -- " + rdr[1]) ;
            }
            rdr.Close() ;
        }
    }
}