/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 19/1/2025
 * Time: 9:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AplicacionCursos
{
	partial class FormularioRegistro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRegistro));
			this.label1 = new System.Windows.Forms.Label();
			this.menuRegistrarCurso = new System.Windows.Forms.MenuStrip();
			this.registrarMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.comboBoxEstudiantes = new System.Windows.Forms.ComboBox();
			this.comboBoxHoras = new System.Windows.Forms.ComboBox();
			this.registrarFinal = new System.Windows.Forms.DateTimePicker();
			this.registrarInicio = new System.Windows.Forms.DateTimePicker();
			this.registrarTipo = new System.Windows.Forms.ComboBox();
			this.registrarInstructor = new System.Windows.Forms.TextBox();
			this.registrarTitulo = new System.Windows.Forms.TextBox();
			this.registrarCodigo = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuRegistrarCurso.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Albert Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.label1.Size = new System.Drawing.Size(684, 92);
			this.label1.TabIndex = 4;
			this.label1.Text = "REGISTRO DE CURSOS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuRegistrarCurso
			// 
			this.menuRegistrarCurso.AutoSize = false;
			this.menuRegistrarCurso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuRegistrarCurso.BackgroundImage")));
			this.menuRegistrarCurso.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuRegistrarCurso.Font = new System.Drawing.Font("Albert Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuRegistrarCurso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.registrarMenu,
									this.limpiarToolStripMenuItem,
									this.salirMenu});
			this.menuRegistrarCurso.Location = new System.Drawing.Point(0, 429);
			this.menuRegistrarCurso.Name = "menuRegistrarCurso";
			this.menuRegistrarCurso.Padding = new System.Windows.Forms.Padding(210, 2, 0, 2);
			this.menuRegistrarCurso.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuRegistrarCurso.Size = new System.Drawing.Size(684, 32);
			this.menuRegistrarCurso.TabIndex = 5;
			this.menuRegistrarCurso.Text = "menuStrip1";
			// 
			// registrarMenu
			// 
			this.registrarMenu.ForeColor = System.Drawing.Color.Linen;
			this.registrarMenu.Name = "registrarMenu";
			this.registrarMenu.Size = new System.Drawing.Size(79, 28);
			this.registrarMenu.Text = "Guardar";
			// 
			// limpiarToolStripMenuItem
			// 
			this.limpiarToolStripMenuItem.ForeColor = System.Drawing.Color.Linen;
			this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
			this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(76, 28);
			this.limpiarToolStripMenuItem.Text = "Limpiar";
			this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.LimpiarToolStripMenuItemClick);
			// 
			// salirMenu
			// 
			this.salirMenu.ForeColor = System.Drawing.Color.White;
			this.salirMenu.Name = "salirMenu";
			this.salirMenu.Size = new System.Drawing.Size(55, 28);
			this.salirMenu.Text = "Salir";
			this.salirMenu.Click += new System.EventHandler(this.SalirMenuClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.comboBoxEstudiantes);
			this.groupBox1.Controls.Add(this.comboBoxHoras);
			this.groupBox1.Controls.Add(this.registrarFinal);
			this.groupBox1.Controls.Add(this.registrarInicio);
			this.groupBox1.Controls.Add(this.registrarTipo);
			this.groupBox1.Controls.Add(this.registrarInstructor);
			this.groupBox1.Controls.Add(this.registrarTitulo);
			this.groupBox1.Controls.Add(this.registrarCodigo);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
			this.groupBox1.Location = new System.Drawing.Point(0, 177);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(684, 252);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CAMBIAR POR INDICADO ";
			// 
			// checkBox1
			// 
			this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
			this.checkBox1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(103, 143);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(30, 25);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// comboBoxEstudiantes
			// 
			this.comboBoxEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEstudiantes.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxEstudiantes.FormattingEnabled = true;
			this.comboBoxEstudiantes.Location = new System.Drawing.Point(171, 110);
			this.comboBoxEstudiantes.Name = "comboBoxEstudiantes";
			this.comboBoxEstudiantes.Size = new System.Drawing.Size(60, 26);
			this.comboBoxEstudiantes.TabIndex = 40;
			// 
			// comboBoxHoras
			// 
			this.comboBoxHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxHoras.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxHoras.FormattingEnabled = true;
			this.comboBoxHoras.Location = new System.Drawing.Point(74, 81);
			this.comboBoxHoras.Name = "comboBoxHoras";
			this.comboBoxHoras.Size = new System.Drawing.Size(120, 26);
			this.comboBoxHoras.TabIndex = 7;
			// 
			// registrarFinal
			// 
			this.registrarFinal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrarFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.registrarFinal.Location = new System.Drawing.Point(428, 114);
			this.registrarFinal.Name = "registrarFinal";
			this.registrarFinal.Size = new System.Drawing.Size(114, 26);
			this.registrarFinal.TabIndex = 39;
			// 
			// registrarInicio
			// 
			this.registrarInicio.CalendarForeColor = System.Drawing.Color.DimGray;
			this.registrarInicio.CalendarMonthBackground = System.Drawing.Color.Linen;
			this.registrarInicio.CalendarTitleBackColor = System.Drawing.Color.SaddleBrown;
			this.registrarInicio.CalendarTitleForeColor = System.Drawing.Color.DimGray;
			this.registrarInicio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrarInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.registrarInicio.Location = new System.Drawing.Point(428, 82);
			this.registrarInicio.Name = "registrarInicio";
			this.registrarInicio.Size = new System.Drawing.Size(114, 26);
			this.registrarInicio.TabIndex = 38;
			// 
			// registrarTipo
			// 
			this.registrarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registrarTipo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrarTipo.ForeColor = System.Drawing.Color.DimGray;
			this.registrarTipo.FormattingEnabled = true;
			this.registrarTipo.Items.AddRange(new object[] {
									"Presencial",
									"Semipresencial",
									"Virtual"});
			this.registrarTipo.Location = new System.Drawing.Point(423, 50);
			this.registrarTipo.Name = "registrarTipo";
			this.registrarTipo.Size = new System.Drawing.Size(158, 26);
			this.registrarTipo.TabIndex = 7;
			// 
			// registrarInstructor
			// 
			this.registrarInstructor.AcceptsReturn = true;
			this.registrarInstructor.AcceptsTab = true;
			this.registrarInstructor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.registrarInstructor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrarInstructor.ForeColor = System.Drawing.Color.DimGray;
			this.registrarInstructor.Location = new System.Drawing.Point(119, 53);
			this.registrarInstructor.MaxLength = 80;
			this.registrarInstructor.Name = "registrarInstructor";
			this.registrarInstructor.Size = new System.Drawing.Size(220, 19);
			this.registrarInstructor.TabIndex = 37;
			this.registrarInstructor.Enter += new System.EventHandler(this.RegistrarInstructorEnter);
			this.registrarInstructor.Leave += new System.EventHandler(this.RegistrarInstructorLeave);
			// 
			// registrarTitulo
			// 
			this.registrarTitulo.AcceptsReturn = true;
			this.registrarTitulo.AcceptsTab = true;
			this.registrarTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.registrarTitulo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrarTitulo.ForeColor = System.Drawing.Color.DimGray;
			this.registrarTitulo.Location = new System.Drawing.Point(435, 22);
			this.registrarTitulo.MaxLength = 150;
			this.registrarTitulo.Name = "registrarTitulo";
			this.registrarTitulo.Size = new System.Drawing.Size(287, 19);
			this.registrarTitulo.TabIndex = 36;
			this.registrarTitulo.Enter += new System.EventHandler(this.RegistrarTituloEnter);
			this.registrarTitulo.Leave += new System.EventHandler(this.RegistrarTituloLeave);
			// 
			// registrarCodigo
			// 
			this.registrarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.registrarCodigo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrarCodigo.ForeColor = System.Drawing.Color.DimGray;
			this.registrarCodigo.Location = new System.Drawing.Point(86, 22);
			this.registrarCodigo.MaxLength = 5;
			this.registrarCodigo.Name = "registrarCodigo";
			this.registrarCodigo.Size = new System.Drawing.Size(253, 19);
			this.registrarCodigo.TabIndex = 35;
			this.registrarCodigo.Enter += new System.EventHandler(this.RegistrarCodigoEnter);
			this.registrarCodigo.Leave += new System.EventHandler(this.RegistrarCodigoLeave);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(14, 137);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(87, 25);
			this.label23.TabIndex = 34;
			this.label23.Text = "Activo:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(364, 120);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(58, 18);
			this.label17.TabIndex = 32;
			this.label17.Text = "Final:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(364, 86);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 18);
			this.label19.TabIndex = 30;
			this.label19.Text = "Inicio:";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(12, 84);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 18);
			this.label21.TabIndex = 28;
			this.label21.Text = "Horas:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(12, 113);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(159, 18);
			this.label15.TabIndex = 26;
			this.label15.Text = "N° de estudiantes:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(364, 53);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 18);
			this.label11.TabIndex = 24;
			this.label11.Text = "Tipo:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(12, 53);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(101, 18);
			this.label13.TabIndex = 22;
			this.label13.Text = "Instructor:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(363, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 18);
			this.label9.TabIndex = 20;
			this.label9.Text = "Titulo:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 18);
			this.label6.TabIndex = 18;
			this.label6.Text = "Código:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DimGray;
			this.label2.Location = new System.Drawing.Point(0, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(684, 46);
			this.label2.TabIndex = 7;
			this.label2.Text = "Bienvenido al area de registro y actualización.\r\nIngresa los datos o actualiza lo" +
			" mostrados para registrar o actualizar un curso.\r\n";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DimGray;
			this.label3.Location = new System.Drawing.Point(0, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(684, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Usa el boton limpiar para limpiar todo";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FormularioRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.ControlBox = false;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuRegistrarCurso);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormularioRegistro";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Formulario de registro de cursos";
			this.Load += new System.EventHandler(this.FormularioRegistroLoad);
			this.menuRegistrarCurso.ResumeLayout(false);
			this.menuRegistrarCurso.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ComboBox comboBoxEstudiantes;
		private System.Windows.Forms.ComboBox comboBoxHoras;
		private System.Windows.Forms.DateTimePicker registrarFinal;
		private System.Windows.Forms.DateTimePicker registrarInicio;
		private System.Windows.Forms.ComboBox registrarTipo;
		private System.Windows.Forms.TextBox registrarTitulo;
		private System.Windows.Forms.TextBox registrarInstructor;
		private System.Windows.Forms.TextBox registrarCodigo;
		private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolStripMenuItem salirMenu;
		private System.Windows.Forms.ToolStripMenuItem registrarMenu;
		private System.Windows.Forms.MenuStrip menuRegistrarCurso;
		private System.Windows.Forms.Label label1;
		
		void CheckBox1CheckedChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}
