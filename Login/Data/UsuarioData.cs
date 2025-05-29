using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Data
{
    public class UsuarioData
    {
        private readonly Connection connection = new Connection();

        public bool ValidarUsuario(string usuario, string clave)
        {
            using (SqlConnection conn = connection.ServerConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@usuario AND Clave=@clave";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                int resp = (int)cmd.ExecuteScalar();
                return resp > 0;
            }
        }


    }
}
