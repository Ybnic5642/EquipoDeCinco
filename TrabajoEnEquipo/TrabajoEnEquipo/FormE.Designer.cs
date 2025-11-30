/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 30/11/2025
 * Hora: 03:45 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace TrabajoEnEquipo
{
	partial class FormE
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
			this.btnGenerar = new System.Windows.Forms.Button();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnGenerar
			// 
			this.btnGenerar.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGenerar.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerar.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnGenerar.Location = new System.Drawing.Point(109, 269);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(154, 69);
			this.btnGenerar.TabIndex = 1;
			this.btnGenerar.Text = "Generar";
			this.btnGenerar.UseVisualStyleBackColor = false;
			this.btnGenerar.Click += new System.EventHandler(this.BtnGenerarClick);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOrdenar.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrdenar.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnOrdenar.Location = new System.Drawing.Point(109, 390);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(154, 69);
			this.btnOrdenar.TabIndex = 2;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = false;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(30, 31);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(323, 210);
			this.listBox1.TabIndex = 3;
			// 
			// FormE
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(382, 519);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.btnGenerar);
			this.Name = "FormE";
			this.Text = "FormE";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.Button btnGenerar;
	}
}
