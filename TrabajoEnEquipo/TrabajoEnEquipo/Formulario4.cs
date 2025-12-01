/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 30/11/2025
 * Hora: 07:09 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoEnEquipo
{
	/// <summary>
	/// Description of Formulario4.
	/// </summary>
	public partial class Formulario4 : Form
	{
		double suma = 0.0;
		public Formulario4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BtnregistrarClick(object sender, EventArgs e)
		{
			if(cboasignatura.SelectedIndex== -1)
				MessageBox.Show("Escoja el Submódulo");
			else if(txt1.Text=="" || txt2.Text=="" || txt3.Text=="" )
				MessageBox.Show("Diga las calificaciones obtenidas");
			else if(txtnombre.Text=="" )
				MessageBox.Show("Diga su nombre");
			else if(cboasignatura.Text=="")
				MessageBox.Show("Escoja su asignatura");
			else if(cboespecialidad.Text=="")
				MessageBox.Show("Escoja su especialidad");
			else{
				
				string submo = cboasignatura.Text;
				double Primero = Convert.ToDouble(txt1.Text);
				double Segundo = Convert.ToDouble(txt2.Text);
				double Tercero = Convert.ToDouble(txt3.Text);
				
				double C = 3;
				double PromedrioGral;
				
				suma += Primero + Segundo + Tercero;
				PromedrioGral = suma / C;
				
				string Aprob;
				double promedio = (Primero + Segundo + Tercero)/3.0;
				if(promedio >=6.0){
					Aprob = "Aprovado";
				}else{
					Aprob = "Reprobado";
				}
					
				ListViewItem fila = new ListViewItem(submo);
				fila.SubItems.Add(Primero.ToString());
				fila.SubItems.Add(Segundo.ToString());
				fila.SubItems.Add(Tercero.ToString());
				fila.SubItems.Add(promedio.ToString());
				fila.SubItems.Add(Aprob);
				listView1.Items.Add(fila);
				BtncancelarClick(sender, e);
				txtpromediogral.Text = Convert.ToString(PromedrioGral);
				C += 3;
			}
					
					
		}
		
		void Formulario4Load(object sender, EventArgs e)
		{
			lblfechaac.Text = DateTime.Today.Date.ToString("d");			
		}
		
		void BtncancelarClick(object sender, EventArgs e)
		{
			cboasignatura.Text = "";
			cbosemestre.Text = "";
			cboespecialidad.Text = "";
			txt1.Clear();
			txt2.Clear();
			txt3.Clear();
			txtnombre.Clear();
			txtpromediogral.Text=(0).ToString();
			txtnombre.Focus();						
		}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
