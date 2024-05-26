namespace TSO_Proyect
{
	partial class InfoA
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.lblNC = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblSemestre = new System.Windows.Forms.Label();
			this.lblCarrera = new System.Windows.Forms.Label();
			this.lblSaldo = new System.Windows.Forms.Label();
			this.btnVolver = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(466, 421);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "¡Comprar!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblNC
			// 
			this.lblNC.AutoSize = true;
			this.lblNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNC.Location = new System.Drawing.Point(429, 72);
			this.lblNC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNC.Name = "lblNC";
			this.lblNC.Size = new System.Drawing.Size(66, 24);
			this.lblNC.TabIndex = 9;
			this.lblNC.Text = "label1";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(487, 138);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(66, 24);
			this.lblNombre.TabIndex = 10;
			this.lblNombre.Text = "label1";
			// 
			// lblSemestre
			// 
			this.lblSemestre.AutoSize = true;
			this.lblSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSemestre.Location = new System.Drawing.Point(506, 203);
			this.lblSemestre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSemestre.Name = "lblSemestre";
			this.lblSemestre.Size = new System.Drawing.Size(66, 24);
			this.lblSemestre.TabIndex = 11;
			this.lblSemestre.Text = "label1";
			// 
			// lblCarrera
			// 
			this.lblCarrera.AutoSize = true;
			this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCarrera.Location = new System.Drawing.Point(487, 269);
			this.lblCarrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCarrera.Name = "lblCarrera";
			this.lblCarrera.Size = new System.Drawing.Size(66, 24);
			this.lblCarrera.TabIndex = 12;
			this.lblCarrera.Text = "label1";
			// 
			// lblSaldo
			// 
			this.lblSaldo.AutoSize = true;
			this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaldo.Location = new System.Drawing.Point(462, 336);
			this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSaldo.Name = "lblSaldo";
			this.lblSaldo.Size = new System.Drawing.Size(66, 24);
			this.lblSaldo.TabIndex = 13;
			this.lblSaldo.Text = "label1";
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(375, 421);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(75, 23);
			this.btnVolver.TabIndex = 14;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TSO_Proyect.Properties.Resources.Carnet_de_Identificación_para_Empresa_Electrónica_Moderno_Azul__4_;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(758, 479);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// InfoA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 477);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.lblSaldo);
			this.Controls.Add(this.lblCarrera);
			this.Controls.Add(this.lblSemestre);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblNC);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "InfoA";
			this.Text = "InfoA";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNC;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnVolver;
    }
}