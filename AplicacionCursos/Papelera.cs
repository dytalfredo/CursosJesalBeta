/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 20/1/2025
 * Time: 7:15 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionCursos
{
	/// <summary>
	/// Description of Papelera.
	/// </summary>
	public partial class Papelera : Form
	{
		private Cursos cursos = Cursos.Instance;
		public Papelera()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		
		
		void ImprimirCursosNoActivos(){
			
			Form este = this;	
			int i = 1;
			MenuStrip menuPapelera = new MenuStrip();
			this.Controls.Add(menuPapelera);
			
			menuPapelera.AutoSize = false;
			
			menuPapelera.Dock = System.Windows.Forms.DockStyle.Bottom;
			menuPapelera.Font = new System.Drawing.Font("Albert Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			menuPapelera.BackColor = System.Drawing.Color.SaddleBrown;
			menuPapelera.Location = new System.Drawing.Point(0, 343);
			menuPapelera.Name = "menuPapelera";
			menuPapelera.Padding = new System.Windows.Forms.Padding(210, 2, 0, 2);
			menuPapelera.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			menuPapelera.Size = new System.Drawing.Size(600, 32);
			menuPapelera.TabIndex = 1;
			menuPapelera.Text = "menuStrip1";
			
			ToolStripMenuItem registrarMenu = new ToolStripMenuItem();
			
		
			menuPapelera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									registrarMenu});
				
			
			registrarMenu.ForeColor = System.Drawing.Color.Linen;
			registrarMenu.Name = "registrarMenu";
			registrarMenu.Size = new System.Drawing.Size(187, 28);
			registrarMenu.Text = "Regresar";
			
			registrarMenu.Click += delegate { este.Close(); };
			
			
			
			
			//Cursos lista = cursos.ObtenerCursosInactivos();
			foreach (Curso curso in cursos.ObtenerCursosInactivos()) {			
			GroupBox grupo = new GroupBox();
			this.Controls.Add(grupo);
			grupo.Dock = System.Windows.Forms.DockStyle.Top;
			grupo.BackColor = System.Drawing.Color.Linen;
			grupo.Location = new System.Drawing.Point(0, 0);
			grupo.Name = "Grupo"+curso.titulo_del_curso;
			grupo.Size = new System.Drawing.Size(600, 70);
			grupo.TabIndex = 0;
			grupo.TabStop = false;
			grupo.Text = "groupBox1";
			grupo.Location = new System.Drawing.Point(50, 50 + (i * 30));
			grupo.ResumeLayout(false);
			grupo.Text = curso.titulo_del_curso;
			grupo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			Label titulo = new Label();
			this.Controls.Add(titulo);
			grupo.Controls.Add(titulo);
			titulo.Text = "INSTRUCTOR: " +curso.instructor_del_curso;
			titulo.Dock = System.Windows.Forms.DockStyle.Left;
			titulo.Location = new System.Drawing.Point(3, 16);
			titulo.Size = new System.Drawing.Size(400, 23);
			titulo.Name = "Label"+curso.titulo_del_curso;
			titulo.TabIndex = 0;
			titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			CheckBox activado = new CheckBox();
			this.Controls.Add(activado);
			grupo.Controls.Add(activado);
			activado.Dock = System.Windows.Forms.DockStyle.Right;
			activado.Location = new System.Drawing.Point(493, 16);
			activado.Name = curso.codigo;
			activado.Size = new System.Drawing.Size(104, 32);
			activado.TabIndex = 1;
			activado.Text = curso.codigo + " Activar";
			activado.UseVisualStyleBackColor = true;
			
			
			
			
			
			
			activado.CheckedChanged += delegate{cursos.Activar(activado.Name);
			this.Controls.Clear();
			ImprimirCursosNoActivos();
			
			
			};
			
		
				
				i++;
				
			}}
		
		void PapeleraLoad(object sender, EventArgs e)
		{
			ImprimirCursosNoActivos();
			
			
		}
		
	
	
		

		
	}
}
