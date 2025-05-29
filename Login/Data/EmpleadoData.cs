using Login.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Login.Data
{
    public class EmpleadoData
    {
        private readonly Connection connection = new Connection();

        public DataTable ObtenerEmpleados(string buscar)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using SqlConnection conn = connection.ServerConnection();
                conn.Open();
                string query = @"
                                    SELECT
	                                    E.ID AS [ID],
	                                    E.Nombre AS [EMPLEADO],
	                                    E.Edad AS [EDAD],
	                                    E.Salario AS [SALARIO],
	                                    D.Nombre AS [DEPARTAMENTO]
                                    FROM
	                                    Empleados E
                                    INNER JOIN Departamentos D ON E.DeptoID = D.ID
                                    WHERE
	                                    UPPER(E.Nombre) + UPPER(D.Nombre) LIKE '%' + UPPER(@Buscar) + '%'";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Buscar", buscar);

                using SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public string CrearEmpleado(EmpleadoModel model)
        {
            string resp = "";
            try
            {
                using SqlConnection conn = connection.ServerConnection();
                conn.Open();
                string query = @"
                                INSERT INTO 
	                                Empleados 
		                                (Nombre, Edad, Salario, DeptoID) 
                                VALUES 
		                                (@Nombre, @Edad, @Salario, @DepartamentoId)";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", model.Nombre);
                cmd.Parameters.AddWithValue("@Edad", model.Edad);
                cmd.Parameters.AddWithValue("@Salario", model.Salario);
                cmd.Parameters.AddWithValue("@DepartamentoId", model.IdDepartamento);

                resp = cmd.ExecuteNonQuery() >= 1 ? "Ok" : "Fail";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resp;
        }

        public string ActualizarEmpleado(EmpleadoModel model)
        {
            string resp = "";
            try
            {
                using SqlConnection conn = connection.ServerConnection();
                conn.Open();
                string query = @"
                                UPDATE
	                                Empleados
                                SET
	                                Nombre = @Nombre, Edad = @Edad, Salario = @Salario, DeptoID = @DepartamentoId
                                WHERE
	                                ID = @Id";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", model.Id);
                cmd.Parameters.AddWithValue("@Nombre", model.Nombre);
                cmd.Parameters.AddWithValue("@Edad", model.Edad);
                cmd.Parameters.AddWithValue("@Salario", model.Salario);
                cmd.Parameters.AddWithValue("@DepartamentoId", model.IdDepartamento);

                resp = cmd.ExecuteNonQuery() >= 1 ? "Ok" : "Fail";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resp;
        }

        public string EliminarEmpleado(int id)
        {
            string resp = "";

            try
            {
                using SqlConnection conn = connection.ServerConnection();
                conn.Open();
                string query = @"
                                DELETE FROM Empleados
                                WHERE 
	                                ID = @Id";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                resp = cmd.ExecuteNonQuery() >= 1 ? "Ok" : "Fail";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return resp;
        }
    }
}
