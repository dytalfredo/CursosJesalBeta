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

		public FormularioRegistro(Curso curso){
			InitializeComponent();
			menuRegistrarCurso.Renderer = new MyRenderer();
			
			label1.Text = "ACTUALIZAR CURSO";
			label23.Visible = true;
			checkBox1.Visible = true;
			registrarCodigo.Enabled = false;
			
			formulario_vesion_actualizar = true;
			curso_seleccionado_para_actualizar = curso;
			
			
			// Cargar en formulario datos del curso seleccionado para su actualizacion
			registrarCodigo.Text = curso.codigo;
			registrarInstructor.Text = curso.instructor_del_curso;
			registrarTitulo.Text = curso.titulo_del_curso;
			
			//SeleccionarValorEnComboBox(comboBoxHoras, curso.horas);
			SeleccionarValorEnComboBox(registrarTipo, curso.modalidad);
			//SeleccionarValorEnComboBox(comboBoxEstudiantes, curso.cantidad_de_estudiantes);
			
			registrarFinal.Value = curso.fecha_culminacion;
			registrarInicio.Value = curso.fecha_inicio;
			
			checkBox1.Checked = curso.activo;
			
			//Eventos 
			registrarMenu.Text = "Actualizar";
			registrarMenu.Click += new EventHandler(actualizarCursoClick);

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
			
			if(!formulario_vesion_actualizar){
				registrarCodigo.Text = "Codigo del curso";
				registrarCodigo.ForeColor = Color.LightGray;
				registrarTitulo.Text = "Ingrese el titulo del curso";
				registrarTitulo.ForeColor = Color.LightGray;
				registrarInstructor.Text = "Profesor o instructor";
				registrarInstructor.ForeColor = Color.LightGray;
			}
			
		}
		
		void LimpiarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(formulario_vesion_actualizar){
				registrarTitulo.Text="";
				registrarInstructor.Text="";
				registrarTipo.Text="";
				comboBoxEstudiantes.Text="";
				comboBoxHoras.Text="";
			} else {
				registrarCodigo.Text="";
				registrarTitulo.Text="";
				registrarInstructor.Text="";
				registrarTipo.Text="";
				comboBoxEstudiantes.Text="";
				comboBoxHoras.Text="";
			}
			
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
				if(formulario_vesion_actualizar){
					registrarCodigo.Text = curso_seleccionado_para_actualizar.codigo;
					registrarCodigo.ForeColor= Color.LightGray;
					return;
				}
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
				if(formulario_vesion_actualizar){
					registrarTitulo.Text = curso_seleccionado_para_actualizar.titulo_del_curso;
					registrarTitulo.ForeColor= Color.LightGray;
					return;
				}
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
				if(formulario_vesion_actualizar){
					registrarInstructor.Text = curso_seleccionado_para_actualizar.instructor_del_curso;
					registrarInstructor.ForeColor= Color.LightGray;
					return;
				}
				registrarInstructor.Text="Profesor o instructor";
				registrarInstructor.ForeColor= Color.LightGray;
			}
		}
		
		
		
		void actualizarCursoClick(object sender, EventArgs e){
			if (string.IsNullOrWhiteSpace(registrarCodigo.Text) ||
				string.IsNullOrWhiteSpace(registrarInstructor.Text) ||
			    string.IsNullOrWhiteSpace(registrarTitulo.Text) ||
			    comboBoxHoras.SelectedItem == null ||
			    comboBoxEstudiantes.SelectedItem == null)
			{
    				MessageBox.Show("Por favor, complete todos los campos antes de actualizar el curso.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    				return;
			}
			
			Curso curso = new Curso(
				registrarCodigo.Text,
				registrarInstructor.Text,
				registrarTitulo.Text,
				(int)comboBoxHoras.SelectedItem,
				registrarFinal.Value,
				registrarInicio.Value,
				(int)comboBoxEstudiantes.SelectedItem
			);
			
			if (registrarTipo.Text == Modalidad.Presencial.ToString())
			{
			    curso.modalidad = Modalidad.Presencial;
			}
			else if (registrarTipo.Text == Modalidad.Semipresencial.ToString())
			{
			    curso.modalidad = Modalidad.Semipresencial;
			}
			else if (registrarTipo.Text == Modalidad.Remoto.ToString())
			{
			    curso.modalidad = Modalidad.Remoto;
			}
 			else {
				MessageBox.Show("Modalidad no disponible", "Error", MessageBoxButtons.OK);
			}
			
			try {
				cursos.Actualizar(curso);
				MessageBox.Show("Curso actualizado con exito", "Actualizacion", MessageBoxButtons.OK);
				limpiarCamposDeRegistro();
				this.Close();
				
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message, "Actualizacion de curso sin exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
		}
		
		void registrarCursoClick(object sender, EventArgs e){
			
			if (string.IsNullOrWhiteSpace(registrarCodigo.Text) ||
				string.IsNullOrWhiteSpace(registrarInstructor.Text) ||
			    string.IsNullOrWhiteSpace(registrarTitulo.Text) ||
			    comboBoxHoras.SelectedItem == null ||
			    comboBoxEstudiantes.SelectedItem == null)
			{
    				MessageBox.Show("Por favor, complete todos los campos antes de registrar el curso.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    				return;
			}
			
			Curso curso = new Curso(
				registrarCodigo.Text,
				registrarInstructor.Text,
				registrarTitulo.Text,
				(int)comboBoxHoras.SelectedItem,
				registrarFinal.Value,
				registrarInicio.Value,
				(int)comboBoxEstudiantes.SelectedItem
			);
			
			
			if (registrarTipo.Text == Modalidad.Presencial.ToString())
			{
			    curso.modalidad = Modalidad.Presencial;
			}
			else if (registrarTipo.Text == Modalidad.Semipresencial.ToString())
			{
			    curso.modalidad = Modalidad.Semipresencial;
			}
			else if (registrarTipo.Text == Modalidad.Remoto.ToString())
			{
			    curso.modalidad = Modalidad.Remoto;
			}
 			else {
				MessageBox.Show("Modalidad no disponible", "Error", MessageBoxButtons.OK);
			}
				
			try {
				cursos.Registrar(curso);
				limpiarCamposDeRegistro();
				MessageBox.Show("Curso registrado con exito", "Registro Exitoso", MessageBoxButtons.OK);
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message, "Registro de curso sin exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
		}
		
		void limpiarCamposDeRegistro(){
			registrarCodigo.Text = "";
			registrarInstructor.Text = "";
			registrarTitulo.Text = "";
			comboBoxHoras.SelectedIndex = -1;
			registrarFinal.Value = DateTime.Now;
			comboBoxEstudiantes.SelectedIndex = -1;
		}
		
		
		private void SeleccionarValorEnComboBox(ComboBox comboBox, object valor)
		{
		    bool encontrado = false;
		
		    for (int i = 0; i < comboBox.Items.Count; i++)
		    {
		        if (comboBox.Items[i].ToString() == valor.ToString())
		        {
		            comboBox.SelectedIndex = i;
		            encontrado = true;
		            break;
		        }
		    }
		
		    if (!encontrado)
		    {
		        MessageBox.Show("El valor no se encontró en el ComboBox.");
		    }
		}

	}
}
