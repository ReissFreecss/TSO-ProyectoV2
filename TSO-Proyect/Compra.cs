using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSO_Proyect
{
	public partial class Compra : Form
	{
        private DataTable studentData;
        private string studentId;
        private decimal currentSaldo;
        public Compra(DataTable studentData)
        {
            InitializeComponent();
            this.studentData = studentData;
            this.studentId = studentData.Rows[0]["ID"].ToString();
            this.currentSaldo = Convert.ToDecimal(studentData.Rows[0]["saldo"]);
        }

        private void button1_Click(object sender, EventArgs e)
		{
            //string nombreLocal = txtNombreLocal.Text;
            if (decimal.TryParse(txtPrecioProducto.Text, out decimal precioProducto))
            {
                if (currentSaldo >= precioProducto)
                {
                    currentSaldo -= precioProducto;
                    UpdateStudentSaldo();

                    Exito exitoForm = new Exito(currentSaldo);
                    exitoForm.Show();
                    this.Close();
                }
                else
                {
                    Nosaldo noSaldoForm = new Nosaldo();
                    noSaldoForm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
            }
        }

        private void UpdateStudentSaldo()
        {
            using (SqlConnection connection = new SqlConnection("Server=CARLOSCALDERON\\SQLEXPRESS;Database=escuela;User ID=sa;Password=123456;MultipleActiveResultSets=true;Trusted_Connection=true;Encrypt=False;"))
            {
                string query = "UPDATE estudiante SET saldo = @saldo WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@saldo", currentSaldo);
                command.Parameters.AddWithValue("@ID", studentId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            InfoA infoForm = new InfoA(studentData); // Si InfoA necesita datos, puedes pasárselos aquí
            infoForm.Show();
            this.Close(); // Cierra la ventana actual
        }
    }
}
