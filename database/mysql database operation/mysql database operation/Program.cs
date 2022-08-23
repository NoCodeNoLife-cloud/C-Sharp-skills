using System;
using MySql.Data.MySqlClient;

namespace mysql_database_operation
{
    public class Student
    {
        public string Num { get; set; }
        public string Name { get; set; }

        public Student(string num, string name)
        {
            Num = num;
            Name = name;
        }

        public override string ToString()
        {
            return $"{nameof(Num)}: {Num}, {nameof(Name)}: {Name}";
        }
    }

    internal class Program
    {
        private static string connStr = "server = localhost; user = root; database = stu; port = 3306; password = 123456";

        public static void Main(string[] args)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // show
            string sql = "SELECT * from student;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1]);
            }

            rdr.Close();

            Console.Out.WriteLine();

            // insert
            sql = "insert into student values('4','yangjingtao')";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "select * from student;";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1]);
            }

            rdr.Close();

            Console.Out.WriteLine();

            // delete
            sql = "delete from student where num='4';";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1]);
            }

            rdr.Close();

            sql = "select * from student;";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1]);
            }

            Console.Out.WriteLine();

            rdr.Close();

            // update
            sql = "update student set num = '100' where name='liangjiawen';";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "select * from student;";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1]);
            }

            Console.Out.WriteLine();

            rdr.Close();

            // to memory
            sql = "select * from student where name = 'caiwei';";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Student student = new Student((string) rdr[0], (string) rdr[1]);
                Console.Out.WriteLine(student);
            }

            rdr.Close();
        }
    }
}