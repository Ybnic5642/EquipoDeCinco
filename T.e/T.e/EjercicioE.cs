/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 29/11/2025
 * Hora: 08:57 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;


namespace T.e
{
	/// <summary>
	/// Description of EjercicioE.
	/// </summary>
	public partial class EjercicioE : Form
	{
		public EjercicioE()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
					}
			
		void btnGenerarClick(object sender, EventArgs e)
		{
			
			    Random r = new Random();
			    listBox1.Items.Clear();
			
			    for (int i = 0; i < 10; i++)
			    {
			        listBox1.Items.Add(r.Next(1, 101));
			    }
					}
		
		void btnOrdenarClick(object sender, EventArgs e)
		{
						    {
			        List<int> nums = new List<int>();
			
			        foreach (var item in listBox1.Items)
			            nums.Add(Convert.ToInt32(item));
			
			        nums.Sort();
			
			        listBox1.Items.Clear();
			        foreach (int n in nums)
			            listBox1.Items.Add(n);
			    }
		}
			}
				}
