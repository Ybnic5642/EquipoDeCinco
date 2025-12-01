/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 01/12/2025
 * Hora: 08:24 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace TrabajoEnEquipo
{
	partial class FormB
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRegistro = new System.Windows.Forms.Button();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnCalificaciones = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(610, 183);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(138, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(329, 62);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menú principal";
			// 
			// btnRegistro
			// 
			this.btnRegistro.BackColor = System.Drawing.Color.Violet;
			this.btnRegistro.Enabled = false;
			this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegistro.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistro.Location = new System.Drawing.Point(86, 227);
			this.btnRegistro.Name = "btnRegistro";
			this.btnRegistro.Size = new System.Drawing.Size(171, 69);
			this.btnRegistro.TabIndex = 1;
			this.btnRegistro.Text = "Registro";
			this.btnRegistro.UseVisualStyleBackColor = false;
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.BackColor = System.Drawing.Color.Violet;
			this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOrdenar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrdenar.Location = new System.Drawing.Point(86, 332);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(171, 69);
			this.btnOrdenar.TabIndex = 2;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = false;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Violet;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(357, 332);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(171, 69);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			// 
			// btnCalificaciones
			// 
			this.btnCalificaciones.BackColor = System.Drawing.Color.Violet;
			this.btnCalificaciones.Enabled = false;
			this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalificaciones.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalificaciones.Location = new System.Drawing.Point(357, 227);
			this.btnCalificaciones.Name = "btnCalificaciones";
			this.btnCalificaciones.Size = new System.Drawing.Size(171, 69);
			this.btnCalificaciones.TabIndex = 3;
			this.btnCalificaciones.Text = "Calificaciones";
			this.btnCalificaciones.UseVisualStyleBackColor = false;
			// 
			// FormB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Plum;
			this.ClientSize = new System.Drawing.Size(611, 450);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnCalificaciones);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.btnRegistro);
			this.Controls.Add(this.panel1);
			this.Name = "FormB";
			this.Text = "FormB";
			this.Load += new System.EventHandler(this.FormBLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCalificaciones;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.Button btnRegistro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
