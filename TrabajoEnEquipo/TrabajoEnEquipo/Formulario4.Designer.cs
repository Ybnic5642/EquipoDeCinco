/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 30/11/2025
 * Hora: 07:09 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace TrabajoEnEquipo
{
	partial class Formulario4
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbltitulo = new System.Windows.Forms.Label();
			this.lblfecha = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.labelp3 = new System.Windows.Forms.Label();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.lblp2 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.lblp1 = new System.Windows.Forms.Label();
			this.cboasignatura = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboespecialidad = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbosemestre = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblfechaac = new System.Windows.Forms.Label();
			this.btnregistrar = new System.Windows.Forms.Button();
			this.btncancelar = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.lblprogral = new System.Windows.Forms.Label();
			this.txtpromediogral = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbltitulo
			// 
			this.lbltitulo.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltitulo.Location = new System.Drawing.Point(157, 9);
			this.lbltitulo.Name = "lbltitulo";
			this.lbltitulo.Size = new System.Drawing.Size(250, 23);
			this.lbltitulo.TabIndex = 2;
			this.lbltitulo.Text = "Cálculo de Promedios";
			// 
			// lblfecha
			// 
			this.lblfecha.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblfecha.Location = new System.Drawing.Point(69, 63);
			this.lblfecha.Name = "lblfecha";
			this.lblfecha.Size = new System.Drawing.Size(120, 23);
			this.lblfecha.TabIndex = 7;
			this.lblfecha.Text = "Fecha Actual:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt3);
			this.groupBox1.Controls.Add(this.labelp3);
			this.groupBox1.Controls.Add(this.txt2);
			this.groupBox1.Controls.Add(this.lblp2);
			this.groupBox1.Controls.Add(this.txt1);
			this.groupBox1.Controls.Add(this.lblp1);
			this.groupBox1.Controls.Add(this.cboasignatura);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cboespecialidad);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbosemestre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtnombre);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 89);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(564, 178);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt3.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt3.Location = new System.Drawing.Point(408, 114);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(100, 21);
			this.txt3.TabIndex = 35;
			// 
			// labelp3
			// 
			this.labelp3.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelp3.Location = new System.Drawing.Point(421, 87);
			this.labelp3.Name = "labelp3";
			this.labelp3.Size = new System.Drawing.Size(87, 23);
			this.labelp3.TabIndex = 34;
			this.labelp3.Text = "Parcial 3";
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt2.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt2.Location = new System.Drawing.Point(473, 54);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 21);
			this.txt2.TabIndex = 33;
			// 
			// lblp2
			// 
			this.lblp2.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblp2.Location = new System.Drawing.Point(491, 27);
			this.lblp2.Name = "lblp2";
			this.lblp2.Size = new System.Drawing.Size(82, 23);
			this.lblp2.TabIndex = 32;
			this.lblp2.Text = "Parcial 2";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt1.Location = new System.Drawing.Point(356, 54);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 21);
			this.txt1.TabIndex = 31;
			// 
			// lblp1
			// 
			this.lblp1.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblp1.Location = new System.Drawing.Point(356, 27);
			this.lblp1.Name = "lblp1";
			this.lblp1.Size = new System.Drawing.Size(83, 23);
			this.lblp1.TabIndex = 30;
			this.lblp1.Text = "Parcial 1";
			// 
			// cboasignatura
			// 
			this.cboasignatura.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboasignatura.FormattingEnabled = true;
			this.cboasignatura.Items.AddRange(new object[] {
									"Pensamiento Matemático",
									"Lengua y Communicación ",
									"Ecosistemas interacciones energía y dinámica",
									"Humanidades",
									"Inglés",
									"Socioemocional",
									"Metodologías Ágiles",
									"Emplea frameworks para el desarrollo de software "});
			this.cboasignatura.Location = new System.Drawing.Point(184, 113);
			this.cboasignatura.Name = "cboasignatura";
			this.cboasignatura.Size = new System.Drawing.Size(121, 21);
			this.cboasignatura.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(166, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(186, 23);
			this.label4.TabIndex = 28;
			this.label4.Text = "Asignatura/Submódulo:";
			// 
			// cboespecialidad
			// 
			this.cboespecialidad.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboespecialidad.FormattingEnabled = true;
			this.cboespecialidad.Items.AddRange(new object[] {
									"Programación",
									"Soporte",
									"Administración ",
									"Alimentos",
									"Ciberseguridad ",
									"Ofimática",
									"Mecánica "});
			this.cboespecialidad.Location = new System.Drawing.Point(184, 52);
			this.cboespecialidad.Name = "cboespecialidad";
			this.cboespecialidad.Size = new System.Drawing.Size(121, 21);
			this.cboespecialidad.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(184, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 23);
			this.label3.TabIndex = 26;
			this.label3.Text = "Especialidad:";
			// 
			// cbosemestre
			// 
			this.cbosemestre.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbosemestre.FormattingEnabled = true;
			this.cbosemestre.Items.AddRange(new object[] {
									"Primer Semestre",
									"Tercer Semestre",
									"Quinto Semestre "});
			this.cbosemestre.Location = new System.Drawing.Point(6, 113);
			this.cbosemestre.Name = "cbosemestre";
			this.cbosemestre.Size = new System.Drawing.Size(121, 21);
			this.cbosemestre.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 23);
			this.label2.TabIndex = 24;
			this.label2.Text = "Semestre:";
			// 
			// txtnombre
			// 
			this.txtnombre.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.txtnombre.Location = new System.Drawing.Point(6, 53);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(154, 21);
			this.txtnombre.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 23);
			this.label1.TabIndex = 22;
			this.label1.Text = "Nombre del Alumno:";
			// 
			// lblfechaac
			// 
			this.lblfechaac.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblfechaac.Location = new System.Drawing.Point(300, 63);
			this.lblfechaac.Name = "lblfechaac";
			this.lblfechaac.Size = new System.Drawing.Size(120, 23);
			this.lblfechaac.TabIndex = 15;
			
			// 
			// btnregistrar
			// 
			this.btnregistrar.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnregistrar.Location = new System.Drawing.Point(235, 288);
			this.btnregistrar.Name = "btnregistrar";
			this.btnregistrar.Size = new System.Drawing.Size(97, 23);
			this.btnregistrar.TabIndex = 16;
			this.btnregistrar.Text = "REGISTRAR";
			this.btnregistrar.UseVisualStyleBackColor = true;
			this.btnregistrar.Click += new System.EventHandler(this.BtnregistrarClick);
			// 
			// btncancelar
			// 
			this.btncancelar.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncancelar.Location = new System.Drawing.Point(354, 288);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(97, 23);
			this.btncancelar.TabIndex = 17;
			this.btncancelar.Text = "CANCELAR";
			this.btncancelar.UseVisualStyleBackColor = true;
			this.btncancelar.Click += new System.EventHandler(this.BtncancelarClick);
			// 
			// btnsalir
			// 
			this.btnsalir.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsalir.Location = new System.Drawing.Point(479, 288);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(97, 23);
			this.btnsalir.TabIndex = 18;
			this.btnsalir.Text = "SALIR";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.BtnsalirClick);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader7});
			this.listView1.Location = new System.Drawing.Point(30, 352);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(531, 97);
			this.listView1.TabIndex = 19;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Parcial 1";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Parcial 2";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Parcial 3";
			this.columnHeader3.Width = 68;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Promedio";
			this.columnHeader4.Width = 74;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Aprovado/Reprobado";
			this.columnHeader5.Width = 130;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Asignatura o Submódulo";
			this.columnHeader7.Width = 130;
			// 
			// lblprogral
			// 
			this.lblprogral.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblprogral.Location = new System.Drawing.Point(157, 498);
			this.lblprogral.Name = "lblprogral";
			this.lblprogral.Size = new System.Drawing.Size(154, 23);
			this.lblprogral.TabIndex = 20;
			this.lblprogral.Text = "Promedio General:";
			// 
			// txtpromediogral
			// 
			this.txtpromediogral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.txtpromediogral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtpromediogral.Location = new System.Drawing.Point(368, 501);
			this.txtpromediogral.Name = "txtpromediogral";
			this.txtpromediogral.Size = new System.Drawing.Size(100, 20);
			this.txtpromediogral.TabIndex = 21;
			// 
			// Formulario4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 565);
			this.Controls.Add(this.txtpromediogral);
			this.Controls.Add(this.lblprogral);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btncancelar);
			this.Controls.Add(this.btnregistrar);
			this.Controls.Add(this.lblfechaac);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblfecha);
			this.Controls.Add(this.lbltitulo);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "Formulario4";
			this.Text = "Formulario4";
			this.Load += new System.EventHandler(this.Formulario4Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtpromediogral;
		private System.Windows.Forms.Label lblprogral;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.Button btnregistrar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbosemestre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboespecialidad;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboasignatura;
		private System.Windows.Forms.Label lblp1;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label lblp2;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.Label labelp3;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.Label lblfechaac;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblfecha;
		private System.Windows.Forms.Label lbltitulo;
	}
}
