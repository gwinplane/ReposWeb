using MySql.Data.MySqlClient;

namespace AddressManagementWeb.Data
{
    public class Database
    {
        private string connectionString =
            "server=localhost;database=address_db;user=root;password=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}