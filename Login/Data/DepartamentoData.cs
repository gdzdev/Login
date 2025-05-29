using Microsoft.Data.SqlClient;
using System.Data;

namespace Login.Data
{
    public class DepartamentoData
    {
        private readonly Connection connection = new Connection();

        public DataTable ObtenerdDepartamentos()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using SqlConnection conn = connection.ServerConnection();
                conn.Open();
                string query = @"
                                SELECT 
	                                D.ID AS [ID],
	                                D.Nombre AS [NOMBRE],
	                                D.Ciudad AS [CIUDAD]
                                FROM
	                                Departamentos D";

                using SqlCommand cmd = new SqlCommand(query, conn);

                using SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }
    }
}
