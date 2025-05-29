using Microsoft.Data.SqlClient;

namespace Login.Data
{
    public class Connection
    {
        private string DataBase;
        private string Server;
        private static Connection conn;

        public Connection()
        {
            this.DataBase = "EmpresaDB";
            this.Server = "GDz\\SQLSERVER";
        }

        public SqlConnection ServerConnection()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = $"Server={this.Server}; " +
                                        $"Database={this.DataBase}; " +
                                        $"Integrated Security=True; " +
                                        $"TrustServerCertificate=True;";
            }
            catch (Exception)
            {
                throw;
            }
            return conn;
        }

        public static Connection GetConnection()
        {
            if (conn == null) return conn = new Connection();
            return conn;
        }
    }
}
