/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 30/11/2025
 * Hora: 03:45 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoEnEquipo
{
	/// <summary>
	/// Description of FormE.
	/// </summary>
	public partial class FormE : Form
	{
		public FormE()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnGenerarClick(object sender, EventArgs e)
		{
			
			    Random r = new Random();
			    listBox1.Items.Clear();

			    for (int i = 0; i < 10; i++)
			    {
			        listBox1.Items.Add(r.Next(1, 101));
			    }
		}
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
		    int[] nums = new int[listBox1.Items.Count];
		
		    for (int i = 0; i < listBox1.Items.Count; i++)
		    {
		        nums[i] = Convert.ToInt32(listBox1.Items[i]);
		    }
		
		    Array.Sort(nums);
		
		    listBox1.Items.Clear();
		    foreach (int n in nums)
		        listBox1.Items.Add(n);

		}
	}
}
