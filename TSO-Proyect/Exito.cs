﻿using System;
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
		public Exito()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form Portada = new Portada();
			Portada.Show();
			this.Hide();
			//Nota, al cerrar el programa al regresar a la portada, el programa no cierra :(
		}
	}
}
