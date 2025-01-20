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
		
			InitializeComponent();
			menuPrincipal.Renderer = new MyRenderer();
	
		}
		
		//HOVER DE LOS MENU ITEMS
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
		
		//BOTON SALIR CON CAJA DE MENSAJE DE CONFIRMACIÓN
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(this, "¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); 
			if (result == DialogResult.Yes) 
			{ Application.Exit();}
	}
		
		//PLACEHOLDER DE LA CAJA DE TEXTO DE BUSCAR
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
		
		//EFECTO HOVER BOTON LUPA BUSCAR	
		void BotonBuscarMouseEnter(object sender, EventArgs e)
		{
			botonBuscar.BackColor=Color.LightGoldenrodYellow;
		}
		

		void RegistrarMenuClick(object sender, EventArgs e)
		{
			FormularioRegistro x = new FormularioRegistro();
			x.Show();
		}
		
		void ActualizarMenuClick(object sender, EventArgs e)
		{
			FormularioRegistro x = new FormularioRegistro("AA-22");
			x.Show();
		}
	}
	
}
