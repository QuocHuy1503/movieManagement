using MySql.Data.MySqlClient;

namespace BlazorApp5.Data
{
    public class DBMySQLUltils
    {
        private static string Host = "localhost";
        private static string UserName = "root";
        private static string Password = "";
        private static int Port = 3306;
        private static string Database = "C";

        public static MySqlConnection GetMySqlConnection()
        {
            string connString = String.Format("Server={0};Database={1};User={2};Password={3};Port={4}", Host, Database, UserName, Password, Port);
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
