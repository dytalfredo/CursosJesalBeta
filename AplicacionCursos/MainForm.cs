/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 19/1/2025
 * Time: 7:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionCursos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			menuPrincipal.Renderer = new MyRenderer();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private class MyRenderer : ToolStripProfessionalRenderer {
        public MyRenderer() : base(new MyColors()) {}
    }

    private class MyColors : ProfessionalColorTable {
        public override Color MenuItemSelected {
            get { return Color.Yellow; }
        }
        public override Color MenuItemSelectedGradientBegin {
            get { return Color.Orange; }
        }
        public override Color MenuItemSelectedGradientEnd {
            get { return Color.LightGoldenrodYellow; }
        }
    }
		

	
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(this, "¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); 
			if (result == DialogResult.Yes) 
			{ Application.Exit();}
	}
		
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			textBoxBuscar.Text ="Ingresa el codigo del curso";
			textBoxBuscar.ForeColor = Color.LightGray;
			panelDatosCurso.Visible = false;
		}
		
		void TextBoxBuscarEnter(object sender, EventArgs e)
		{
			if(textBoxBuscar.Text=="Ingresa el codigo del curso"){
				textBoxBuscar.Text="";
				textBoxBuscar.ForeColor= Color.DimGray;
			}

		}
		
		void TextBoxBuscarLeave(object sender, EventArgs e)
		{
			if(textBoxBuscar.Text==""){
				textBoxBuscar.Text="Ingresa el codigo del curso";
				textBoxBuscar.ForeColor= Color.LightGray;
			}

		}
		
		
	
		
		void BotonBuscarMouseEnter(object sender, EventArgs e)
		{
			botonBuscar.BackColor=Color.LightGoldenrodYellow;
		}
		
		void BotonBuscarClick(object sender, EventArgs e)
		{
			
		}
		
		void RegistrarMenuClick(object sender, EventArgs e)
		{
			FormularioRegistro x = new FormularioRegistro();
			x.Show();
		}
	}
	
}
