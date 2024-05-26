using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSO_Proyect
{
	public partial class Portada : Form
	{
        private DatabaseConnection dbConnection;
        public Portada()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();

            // Agregar el evento KeyPress al TextBox txtID
            txtID.KeyPress += TxtID_KeyPress;
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string studentId = txtID.Text;
                DataTable studentData = dbConnection.GetStudentById(studentId);

                if (studentData.Rows.Count > 0)
                {
                    // Si el estudiante está registrado, abrir InfoA y cerrar la ventana actual
                    InfoA infoForm = new InfoA(studentData);
                    infoForm.Show();
                    this.Hide();
                }
                else
                {
                    // Si el estudiante no está registrado, abrir NoSaldo
                    Nosaldo noSaldoForm = new Nosaldo();
                    noSaldoForm.Show();
                }
            }
        }

        private void btnBuscar_Click_Click(object sender, EventArgs e)
        {
           
        }

    }
}
