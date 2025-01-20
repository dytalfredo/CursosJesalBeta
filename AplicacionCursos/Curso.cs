/*
 * Created by SharpDevelop.
 * User: ddd
 * Date: 1/19/2025
 * Time: 12:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Newtonsoft.Json;
using System.IO;



namespace AplicacionCursos
{
	/// <summary>
	/// Description of Cursos.
	/// </summary>
	public class Curso
	{
	    
		private string _codigo;
		private string _instructor_del_curso;
		private string _titulo_del_curso;
		
		private Modalidad _modalidad;
		
		private int _horas;
		private DateTime _fecha_inicio;
		private DateTime _fecha_culminacion;
		private int _cantidad_de_estudiantes;
		private bool _activo;
		
		// Basics
		public string instructor_del_curso {get {return _instructor_del_curso;} set {_instructor_del_curso = value;}}
		public string titulo_del_curso {get {return _titulo_del_curso;} set {_titulo_del_curso = value;}}
		
		// Modalidades
		public Modalidad modalidad {get {return _modalidad;} set {_modalidad = value;}}
		
		// Detalles
		public int horas {get {return _horas;} set {_horas = value;}}
		public DateTime fecha_culminacion {get {return _fecha_culminacion;} set {_fecha_culminacion = value;}}
		public DateTime fecha_inicio {get {return _fecha_inicio;} set {_fecha_inicio = value;}}
		public int cantidad_de_estudiantes {get {return _cantidad_de_estudiantes;} set {_cantidad_de_estudiantes = value;}}
		public bool activo {get {return _activo;} set {_activo = value;}}
		public string codigo {get {return _codigo;}}
		
	
		public Curso(
			string codigo,
			string instructor_del_curso, 
			string titulo_del_curso, 
			int horas, 
			DateTime fecha_culminacion,
			DateTime fecha_inicio,
			int cantidad_de_estudiantes
			)
		{
			this.instructor_del_curso = instructor_del_curso;
			this.titulo_del_curso = titulo_del_curso;
			this.horas = horas;
			this.fecha_culminacion = fecha_culminacion;
			this.fecha_inicio = fecha_inicio;
			this.cantidad_de_estudiantes = cantidad_de_estudiantes;
			this.modalidad = Modalidad.Presencial;
			
			this._codigo = codigo;
		}
		
		public override string ToString()
		{
			return string.Format("[Curso Codigo={0}, Instructor_del_curso={1}, Titulo_del_curso={2}, Modalidad={3}, Horas={4}, Fecha_culminacion={5}, Cantidad_de_estudiantes={6}, Activo={7}]", _codigo, _instructor_del_curso, _titulo_del_curso, _modalidad, _horas, _fecha_culminacion, _cantidad_de_estudiantes, _activo);
		}

	}
}
