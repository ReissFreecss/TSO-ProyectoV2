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
	public partial class Exito : Form
	{
        private decimal nuevoSaldo;

        public Exito(decimal nuevoSaldo)
        {
            InitializeComponent();
            this.nuevoSaldo = nuevoSaldo;
            DisplayNuevoSaldo();
        }

        private void DisplayNuevoSaldo()
        {
            lblSaldo.Text = nuevoSaldo.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
		{
            this.Close();
            Portada portadaForm = new Portada();
            portadaForm.Show();
        }
	}
}
