using System;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionCursos
{
	/// <summary>
	/// Description of FormularioRegistro.
	/// </summary>
	public partial class FormularioRegistro : Form
	{
		public FormularioRegistro()
		{
			
			InitializeComponent();
			menuRegistrarCurso.Renderer = new MyRenderer();

		}
		
		
		//CONSTRUCTOR PARA ACTUALIZAR CURSOS.
		//TODO: OBTENER TODOS LOS DATOS DEL REGISTROS PARA PASARLOS AL FORMULARIO DE REGISTRO Y ACTUALIZAR.
		public FormularioRegistro(String t){
			InitializeComponent();
			menuRegistrarCurso.Renderer = new MyRenderer();
			registrarCodigo.Text=t;
		
		}
		
		
		//ESTOS SIRVE PARA CAMBIAR EL COLOR DE HOVER DE LOS MENU ITEMS
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
		
		
		//BOTON DE SALIR DEL FORMULARIO CON CAJA DE MENSAJE DE CONFIRMACION
		void SalirMenuClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(this, "¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); 
			if (result == DialogResult.Yes) 
			{ this.Close();}
		}

		void FormularioRegistroLoad(object sender, EventArgs e)
		{
			//CARGANDO LOS DATOS DE 20 A 80 HORAS
				for (int i = 20; i < 81; i++) {
				comboBoxHoras.Items.Add(i);
				}
			//CARGANDO LOS DATOS DE 4 a 10 ESTUDIANTES
				for (int x = 4; x < 11; x++) {
				comboBoxEstudiantes.Items.Add(x);
				}
		}
		
		void LimpiarToolStripMenuItemClick(object sender, EventArgs e)
		{
			registrarCodigo.Text="";
			registrarTitulo.Text="";
			registrarInstructor.Text="";
			registrarTipo.Text="";
			comboBoxEstudiantes.Text="";
			comboBoxHoras.Text="";
		}
	}
}
