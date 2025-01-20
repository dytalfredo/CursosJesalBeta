 	/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 19/1/2025
 * Time: 9:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			menuRegistrarCurso.Renderer = new MyRenderer();
			
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
		
		void SalirMenuClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(this, "¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); 
			if (result == DialogResult.Yes) 
			{ this.Close();}
		}
		
		void DomainUpDown1SelectedItemChanged(object sender, EventArgs e)
		{
			
		}
		
		void FormularioRegistroLoad(object sender, EventArgs e)
		{
			
				for (int i = 20; i < 81; i++) {
				comboBoxHoras.Items.Add(i);
				}
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
