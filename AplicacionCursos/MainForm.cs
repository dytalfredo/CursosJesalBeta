using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AplicacionCursos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Cursos cursos = Cursos.Instance;
		private Curso _CursoSelected = null ;
		
		
		public MainForm()
		{
		
			InitializeComponent();
			menuPrincipal.Renderer = new MyRenderer();
			
			textBoxBuscar.TextChanged += new EventHandler(PintarDeRojoFormatoDeCodigoErroneo);
			textBoxBuscar.KeyUp += new KeyEventHandler(textBoxBuscarKeyPress);
	
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
			
			if(textBoxBuscar.Text == "Ingresa el codigo del curso"){
				textBoxBuscar.Text= "";
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
		
		void textBoxBuscarKeyPress(object sender, EventArgs e){
			if((string.IsNullOrWhiteSpace(textBoxBuscar.Text)) && (panelDatosCurso.Visible)){
				_CursoSelected = null;
				limpiarCamposDeResultadosDeBusqueda();
				panelDatosCurso.Visible = false;
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
			if(_CursoSelected != null){
				FormularioRegistro x = new FormularioRegistro(_CursoSelected);
				x.Show();
			}
			
		}
		
		
		
		void BotonBuscarClick(object sender, EventArgs e)
		{
			limpiarCamposDeResultadosDeBusqueda();
			this._CursoSelected = null;
			
			if(FormatoDeCodigoCorrecto(textBoxBuscar.Text)){
				try {
				Curso cursoBuscado = cursos.Consultar(textBoxBuscar.Text);
				this._CursoSelected = cursoBuscado;
				panelDatosCurso.Visible = true;
				label7.Text = cursoBuscado.codigo;
				label8.Text = cursoBuscado.titulo_del_curso;
				label12.Text = cursoBuscado.instructor_del_curso;
				label10.Text = cursoBuscado.modalidad.ToString();
				label14.Text = cursoBuscado.cantidad_de_estudiantes.ToString();
				label20.Text = cursoBuscado.horas.ToString();
				label18.Text = cursoBuscado.fecha_inicio.Date.ToString("dd-MM-yyyy");
				label16.Text = cursoBuscado.fecha_culminacion.Date.ToString("dd-MM-yyyy");
				if (cursoBuscado.activo) {
					labelActivo.Text="SI";
					
				}else{
					labelActivo.Text="NO";
				}
				
				} catch(Exception ex){
					MessageBox.Show("El curso no se encuentra registrado", "Busqueda", MessageBoxButtons.OK);
				}
			}
			
			else {
				MessageBox.Show("Formato de codigo erroneo", "Formato", MessageBoxButtons.OK);
			}
		}
		
		void PintarDeRojoFormatoDeCodigoErroneo(object sender, EventArgs e){
			if(!FormatoDeCodigoCorrecto(textBoxBuscar.Text)){
				textBoxBuscar.ForeColor = Color.Red;
			} else {
				textBoxBuscar.ForeColor = Color.Gray;
			}
		}
		
		bool FormatoDeCodigoCorrecto(String texto){
			string patron = @"^[A-Za-z]{2}-\d{2}$";
			Regex formato = new Regex(patron);
			
			
			if(!formato.IsMatch(texto)){
				return false;
			} 
			else {
				return true;
			}
		}
		
		void limpiarCamposDeResultadosDeBusqueda(){
			
				label7.Text = "";
				label8.Text = "";
				label12.Text = "";
				label10.Text = "";
				label14.Text = "";
				label20.Text = "";
				label16.Text = "";
				labelActivo.Text = "";
		}
		
		
		
		void Label15Click(object sender, EventArgs e)
		{
			
		}
		
		void BorrarMenuClick(object sender, EventArgs e)
		{
			Papelera x = new Papelera();
				x.Show();
		}
		
	
	}
	
}
