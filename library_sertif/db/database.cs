using MySql.Data.MySqlClient;

namespace LibrarySystem.Data
{
    class Database
    {
        public static MySqlConnection GetConnection()
        {
            string connStr =
                "server=localhost;" +
                "database=library_db;" +
                "uid=root;" +
                "pwd=;";

            MySqlConnection conn = new MySqlConnection(connStr);
            return conn;
        }
    }
}
