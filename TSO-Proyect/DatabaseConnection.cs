using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSO_Proyect
{
    public class DatabaseConnection
    {
        private string connectionString = "Server=CARLOSCALDERON\\SQLEXPRESS;Database=escuela;User ID=sa;Password=123456;MultipleActiveResultSets=true;Trusted_Connection=true;Encrypt=False;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable GetStudentById(string id)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM estudiante WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);

                return studentTable;
            }
        }
    }
}
