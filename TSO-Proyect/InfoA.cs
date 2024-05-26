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
	public partial class InfoA : Form
	{
        private DataTable studentData;
        public InfoA(DataTable studentData)
        {
            InitializeComponent();
            this.studentData = studentData;
            DisplayStudentInfo();
        }
        private void DisplayStudentInfo()
        {
            if (studentData.Rows.Count > 0)
            {
                DataRow row = studentData.Rows[0];
                //TxtID.Text = row["ID"].ToString();
                lblNC.Text = row["NC"].ToString();
                lblNombre.Text = row["nombre"].ToString();
                lblSemestre.Text = row["semestre"].ToString();
                lblCarrera.Text = row["carrera"].ToString();
                lblSaldo.Text = row["saldo"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Compra compraForm = new Compra(studentData);
            compraForm.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Portada portadaForm = new Portada();
            portadaForm.Show();
            this.Close(); // Cierra la ventana actual
        }
    }
}
