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
	/// Autores: Alfredo Mendoza, Jesus Castillo
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
		}
		
	}
}
