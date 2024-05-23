using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace TSO_Proyect
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort; // Referencia para el puerto serial del lector RFID
        private string idTarjeta; // Variable para almacenar la ID de la tarjeta leída

        // Comentario x
        public Form1()
        {
            InitializeComponent();
        }

        // Manejador del evento DataReceived del puerto serial
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string inputData = sp.ReadExisting().Trim(); // Lee los datos del puerto serial
            this.Invoke((MethodInvoker)delegate {
                idTarjeta = inputData; // Almacena la ID de la tarjeta leída
            });
        }

        // Evento del botón btnLeerTarjeta
        private void btnLeerTarjeta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idTarjeta))
            {
                ObtenerInformacionEstudiante(idTarjeta); // Llama al método para obtener la información del estudiante
            }
            else
            {
                MessageBox.Show("No se ha leído ninguna tarjeta RFID.");
            }
        }

        // Método para obtener la información del estudiante desde la base de datos
        private void ObtenerInformacionEstudiante(string idTarjeta)
        {
            // Cadena de conexión a la base de datos CAMBIENLA POR SUS CREDENCIALES
            string connectionString = "Server=localhost;port=3306;database=TSO-BD;uid=root;password=chocomilk";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Consulta SQL para obtener la información del estudiante
                string query = "SELECT Id, Nombre, Carrera, Semestre, Saldo, Imagen FROM Estudiantes WHERE IdTarjeta = @IdTarjeta";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdTarjeta", idTarjeta); // Parámetro para la consulta
                connection.Open(); // Abre la conexión
                SqlDataReader reader = command.ExecuteReader(); // Ejecuta la consulta
                if (reader.Read()) // Si se encuentra el estudiante
                {
                    // Asigna los valores obtenidos a los controles del formulario
                    txtId.Text = reader["Id"].ToString();
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtCarrera.Text = reader["Carrera"].ToString();
                    txtSemestre.Text = reader["Semestre"].ToString();
                    txtSaldo.Text = reader["Saldo"].ToString();

                    byte[] imagenBytes = (byte[])reader["Imagen"]; // Obtiene la imagen como un array de bytes
                    pictureBox1.Image = ByteArrayToImage(imagenBytes); // Convierte el array de bytes a una imagen y la muestra
                }
                else
                {
                    MessageBox.Show("Estudiante no encontrado."); // Muestra un mensaje si no se encuentra el estudiante
                }
            }
        }

        // Método para convertir un array de bytes en una imagen
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new System.IO.MemoryStream(byteArrayIn)) // Crea un stream a partir del array de bytes
            {
                return Image.FromStream(ms); // Crea y retorna una imagen a partir del stream
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}