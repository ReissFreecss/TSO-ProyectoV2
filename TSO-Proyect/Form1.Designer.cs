using System.Windows.Forms;

namespace TSO_Proyect
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtCarrera;
        private TextBox txtSemestre;
        private TextBox txtSaldo;
        private PictureBox pictureBox1;
        private Button btnLeerTarjeta;

        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLeerTarjeta = new System.Windows.Forms.Button();
            this.NC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(367, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(367, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(367, 147);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(171, 22);
            this.txtCarrera.TabIndex = 8;
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(367, 108);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(171, 22);
            this.txtSemestre.TabIndex = 9;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(367, 191);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(171, 22);
            this.txtSaldo.TabIndex = 10;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 225);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnLeerTarjeta
            // 
            this.btnLeerTarjeta.Location = new System.Drawing.Point(296, 234);
            this.btnLeerTarjeta.Name = "btnLeerTarjeta";
            this.btnLeerTarjeta.Size = new System.Drawing.Size(100, 23);
            this.btnLeerTarjeta.TabIndex = 6;
            this.btnLeerTarjeta.Text = "Leer Tarjeta";
            this.btnLeerTarjeta.UseVisualStyleBackColor = true;
            this.btnLeerTarjeta.Click += new System.EventHandler(this.btnLeerTarjeta_Click);
            // 
            // NC
            // 
            this.NC.AutoSize = true;
            this.NC.Location = new System.Drawing.Point(293, 32);
            this.NC.Name = "NC";
            this.NC.Size = new System.Drawing.Size(65, 16);
            this.NC.TabIndex = 12;
            this.NC.Text = "N.Control:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Semestre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Carrera:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Saldo:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 291);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NC);
            this.Controls.Add(this.btnLeerTarjeta);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtSemestre);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "RFID Reader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label NC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
