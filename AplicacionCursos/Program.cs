/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 19/1/2025
 * Time: 7:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.IO;

namespace AplicacionCursos
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			
			/*
			Curso nuevo01 = new Curso(
				"Jesus castillo",
				"Cocinar pasticho en 30 minutos",
				60,
				DateTime.Now,
				10
			);*/
			
			//nuevo01.codigo = "AA-23";
			// nuevo01.activo = true;
			//Cursos cursos = new Cursos();
			
			
			 //Console.WriteLine(cursos.cursos);
			 //Console.WriteLine(nuevo01);
			 //Console.WriteLine(cursos);
			 
			 //cursos.Registrar(nuevo01);
			 //Console.WriteLine(cursos.Consultar(nuevo01.codigo));
			 //cursos.Actualizar(nuevo01);
			 //cursos.Eliminar("AA-23");
			 //cursos.Consultar("AA-23");
			 //Console.ReadLine();
		}
		
	}
}
