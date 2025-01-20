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
			
			registrarCodigo.Text = "Codigo del curso";
			registrarCodigo.ForeColor = Color.LightGray;
			registrarTitulo.Text = "Ingrese el titulo del curso";
			registrarTitulo.ForeColor = Color.LightGray;
			registrarInstructor.Text = "Profesor o instructor";
			registrarInstructor.ForeColor = Color.LightGray;
			
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
		
		void RegistrarCodigoEnter(object sender, EventArgs e)
		{
			if(registrarCodigo.Text == "Codigo del curso"){
				registrarCodigo.Text="";
				registrarCodigo.Text.ToUpper();
				registrarCodigo.ForeColor = Color.DimGray;
			}
		}
		
		void RegistrarCodigoLeave(object sender, EventArgs e)
		{
			if(registrarCodigo.Text==""){
				registrarCodigo.Text="Codigo del curso";
				registrarCodigo.ForeColor= Color.LightGray;
			}
		}
		
		void RegistrarTituloEnter(object sender, EventArgs e)
		{
			if(registrarTitulo.Text=="Ingrese el titulo del curso"){
				registrarTitulo.Text="";
				registrarTitulo.ForeColor= Color.DimGray;
			}			
		}
		
		void RegistrarTituloLeave(object sender, EventArgs e)
		{
			if(registrarTitulo.Text==""){
				registrarTitulo.Text="Ingrese el titulo del curso";
				registrarTitulo.ForeColor= Color.LightGray;
			}
		}
		
		void RegistrarInstructorEnter(object sender, EventArgs e)
		{
		
			if(registrarInstructor.Text == "Profesor o instructor"){
				
				
				registrarInstructor.Text = "" ;
				registrarInstructor.ForeColor= Color.DimGray;
			}			
		}
		
		void RegistrarInstructorLeave(object sender, EventArgs e)
		{
			if(registrarInstructor.Text==""){
				registrarInstructor.Text="Profesor o instructor";
				registrarInstructor.ForeColor= Color.LightGray;
			}
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
			
		}
	}
}
