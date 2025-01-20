/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 19/1/2025
 * Time: 7:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AplicacionCursos
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuPrincipal = new System.Windows.Forms.MenuStrip();
			this.registrarMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.actualizarMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.borrarMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.botonBuscar = new System.Windows.Forms.Button();
			this.textBoxBuscar = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panelDatosCurso = new System.Windows.Forms.Panel();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.menuPrincipal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panelDatosCurso.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPrincipal
			// 
			this.menuPrincipal.AutoSize = false;
			this.menuPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPrincipal.BackgroundImage")));
			this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.registrarMenu,
									this.actualizarMenu,
									this.borrarMenu,
									this.salirToolStripMenuItem});
			this.menuPrincipal.Location = new System.Drawing.Point(0, 407);
			this.menuPrincipal.Name = "menuPrincipal";
			this.menuPrincipal.Padding = new System.Windows.Forms.Padding(230, 2, 0, 2);
			this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuPrincipal.Size = new System.Drawing.Size(718, 32);
			this.menuPrincipal.TabIndex = 0;
			this.menuPrincipal.Text = "menuStrip1";
			// 
			// registrarMenu
			// 
			this.registrarMenu.ForeColor = System.Drawing.Color.Linen;
			this.registrarMenu.Name = "registrarMenu";
			this.registrarMenu.Size = new System.Drawing.Size(105, 28);
			this.registrarMenu.Text = "Registrar";
			this.registrarMenu.Click += new System.EventHandler(this.RegistrarMenuClick);
			// 
			// actualizarMenu
			// 
			this.actualizarMenu.ForeColor = System.Drawing.Color.Linen;
			this.actualizarMenu.Name = "actualizarMenu";
			this.actualizarMenu.Size = new System.Drawing.Size(113, 28);
			this.actualizarMenu.Text = "Actualizar";
			this.actualizarMenu.Click += new System.EventHandler(this.ActualizarMenuClick);
			// 
			// borrarMenu
			// 
			this.borrarMenu.ForeColor = System.Drawing.Color.Linen;
			this.borrarMenu.Name = "borrarMenu";
			this.borrarMenu.Size = new System.Drawing.Size(79, 28);
			this.borrarMenu.Text = "Borrar";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(63, 28);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox1.Location = new System.Drawing.Point(0, 336);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(718, 71);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(718, 8);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.label1.Size = new System.Drawing.Size(718, 43);
			this.label1.TabIndex = 3;
			this.label1.Text = "CURSOS JESAL";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DimGray;
			this.label2.Location = new System.Drawing.Point(0, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(718, 28);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cursos para todos";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.botonBuscar);
			this.groupBox1.Controls.Add(this.textBoxBuscar);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 79);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(718, 47);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// botonBuscar
			// 
			this.botonBuscar.BackColor = System.Drawing.Color.Linen;
			this.botonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscar.BackgroundImage")));
			this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.botonBuscar.Location = new System.Drawing.Point(584, 9);
			this.botonBuscar.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.botonBuscar.Name = "botonBuscar";
			this.botonBuscar.Padding = new System.Windows.Forms.Padding(4, 4, 40, 4);
			this.botonBuscar.Size = new System.Drawing.Size(38, 33);
			this.botonBuscar.TabIndex = 9;
			this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.botonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.botonBuscar.UseVisualStyleBackColor = false;
			this.botonBuscar.Click += new System.EventHandler(this.BotonBuscarClick);
			// 
			// textBoxBuscar
			// 
			this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxBuscar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxBuscar.Location = new System.Drawing.Point(203, 15);
			this.textBoxBuscar.Name = "textBoxBuscar";
			this.textBoxBuscar.Size = new System.Drawing.Size(374, 19);
			this.textBoxBuscar.TabIndex = 8;
			this.textBoxBuscar.Enter += new System.EventHandler(this.TextBoxBuscarEnter);
			this.textBoxBuscar.Leave += new System.EventHandler(this.TextBoxBuscarLeave);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label3.Location = new System.Drawing.Point(72, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Buscar Curso";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label4.Location = new System.Drawing.Point(0, 126);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.label4.Size = new System.Drawing.Size(718, 35);
			this.label4.TabIndex = 6;
			this.label4.Text = "Datos del curso";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label5.Location = new System.Drawing.Point(0, 161);
			this.label5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(718, 35);
			this.label5.TabIndex = 7;
			this.label5.Text = "Ingrese los datos del curso para llenar esta zona";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panelDatosCurso
			// 
			this.panelDatosCurso.Controls.Add(this.label22);
			this.panelDatosCurso.Controls.Add(this.label23);
			this.panelDatosCurso.Controls.Add(this.label16);
			this.panelDatosCurso.Controls.Add(this.label17);
			this.panelDatosCurso.Controls.Add(this.label18);
			this.panelDatosCurso.Controls.Add(this.label19);
			this.panelDatosCurso.Controls.Add(this.label20);
			this.panelDatosCurso.Controls.Add(this.label21);
			this.panelDatosCurso.Controls.Add(this.label14);
			this.panelDatosCurso.Controls.Add(this.label15);
			this.panelDatosCurso.Controls.Add(this.label10);
			this.panelDatosCurso.Controls.Add(this.label11);
			this.panelDatosCurso.Controls.Add(this.label12);
			this.panelDatosCurso.Controls.Add(this.label13);
			this.panelDatosCurso.Controls.Add(this.label8);
			this.panelDatosCurso.Controls.Add(this.label9);
			this.panelDatosCurso.Controls.Add(this.label7);
			this.panelDatosCurso.Controls.Add(this.label6);
			this.panelDatosCurso.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelDatosCurso.Location = new System.Drawing.Point(0, 196);
			this.panelDatosCurso.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
			this.panelDatosCurso.Name = "panelDatosCurso";
			this.panelDatosCurso.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
			this.panelDatosCurso.Size = new System.Drawing.Size(718, 165);
			this.panelDatosCurso.TabIndex = 8;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.DimGray;
			this.label22.Location = new System.Drawing.Point(357, 124);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(23, 18);
			this.label22.TabIndex = 17;
			this.label22.Text = "SI";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.ForeColor = System.Drawing.Color.DimGray;
			this.label23.Location = new System.Drawing.Point(287, 124);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(67, 18);
			this.label23.TabIndex = 16;
			this.label23.Text = "Activo:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.DimGray;
			this.label16.Location = new System.Drawing.Point(587, 73);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(86, 18);
			this.label16.TabIndex = 15;
			this.label16.Text = "10/12/2025";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.DimGray;
			this.label17.Location = new System.Drawing.Point(517, 73);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(58, 18);
			this.label17.TabIndex = 14;
			this.label17.Text = "Final:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.DimGray;
			this.label18.Location = new System.Drawing.Point(357, 73);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(86, 18);
			this.label18.TabIndex = 13;
			this.label18.Text = "10/12/2025";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.DimGray;
			this.label19.Location = new System.Drawing.Point(287, 73);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 18);
			this.label19.TabIndex = 12;
			this.label19.Text = "Inicio:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.DimGray;
			this.label20.Location = new System.Drawing.Point(82, 73);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(25, 18);
			this.label20.TabIndex = 11;
			this.label20.Text = "20";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.DimGray;
			this.label21.Location = new System.Drawing.Point(12, 73);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 18);
			this.label21.TabIndex = 10;
			this.label21.Text = "Horas:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.DimGray;
			this.label14.Location = new System.Drawing.Point(679, 42);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(17, 18);
			this.label14.TabIndex = 9;
			this.label14.Text = "4";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.DimGray;
			this.label15.Location = new System.Drawing.Point(515, 42);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(159, 18);
			this.label15.TabIndex = 8;
			this.label15.Text = "N° de estudiantes:";
			this.label15.Click += new System.EventHandler(this.Label15Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.DimGray;
			this.label10.Location = new System.Drawing.Point(346, 42);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 18);
			this.label10.TabIndex = 7;
			this.label10.Text = "Informatica";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.DimGray;
			this.label11.Location = new System.Drawing.Point(287, 42);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 18);
			this.label11.TabIndex = 6;
			this.label11.Text = "Tipo:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.DimGray;
			this.label12.Location = new System.Drawing.Point(113, 42);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(129, 18);
			this.label12.TabIndex = 5;
			this.label12.Text = "Alfredo Mendoza7";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.DimGray;
			this.label13.Location = new System.Drawing.Point(12, 42);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(101, 18);
			this.label13.TabIndex = 4;
			this.label13.Text = "Instructor:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.DimGray;
			this.label8.Location = new System.Drawing.Point(354, 11);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(217, 18);
			this.label8.TabIndex = 3;
			this.label8.Text = "CUrso Aerodinamica Industrial";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DimGray;
			this.label9.Location = new System.Drawing.Point(286, 11);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 18);
			this.label9.TabIndex = 2;
			this.label9.Text = "Titulo:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DimGray;
			this.label7.Location = new System.Drawing.Point(80, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 18);
			this.label7.TabIndex = 1;
			this.label7.Text = "Ab-22";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DimGray;
			this.label6.Location = new System.Drawing.Point(12, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 18);
			this.label6.TabIndex = 0;
			this.label6.Text = "Código:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 411);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(38, 20);
			this.textBox2.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(718, 439);
			this.ControlBox = false;
			this.Controls.Add(this.panelDatosCurso);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuPrincipal);
			this.Controls.Add(this.textBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuPrincipal;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AplicacionCursos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuPrincipal.ResumeLayout(false);
			this.menuPrincipal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panelDatosCurso.ResumeLayout(false);
			this.panelDatosCurso.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button botonBuscar;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panelDatosCurso;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxBuscar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem borrarMenu;
		private System.Windows.Forms.ToolStripMenuItem actualizarMenu;
		private System.Windows.Forms.ToolStripMenuItem registrarMenu;
		private System.Windows.Forms.MenuStrip menuPrincipal;
		
	
	}
}
