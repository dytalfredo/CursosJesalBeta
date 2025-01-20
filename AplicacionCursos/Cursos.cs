using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace AplicacionCursos
{
    /// <summary>
    /// Description of Cursos.
    /// </summary>
    public class Cursos
    {
        public List<Curso> cursos;
        private string ruta_archivo_json = "./registros.json";
        
        // Usamos el Singleton para obtener la instancia única de Cursos
        private static Cursos instancia;
        
        public static Cursos Instance
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Cursos();
                }
                return instancia;
            }
        }

        public Cursos()
        {
            ObtenerArchivo();
        }

        private void GuardarEnArchivo()
        {
            string registros = JsonConvert.SerializeObject(cursos, Formatting.Indented);
            File.WriteAllText(ruta_archivo_json, registros);
        }

        private void ObtenerArchivo()
        {
            if (File.Exists(ruta_archivo_json))
            {
                string json = File.ReadAllText(ruta_archivo_json);
                cursos = JsonConvert.DeserializeObject<List<Curso>>(json) ?? new List<Curso>();
            }
           
        }

        private bool ExisteElCurso(string codigo)
        {
            bool coincidenciaDeCodigo = false;
            int indice = 0;
            while (indice < cursos.Count && !coincidenciaDeCodigo)
            {
                if (cursos[indice].codigo == codigo)
                {
                    coincidenciaDeCodigo = true;
                }
                indice++;
            }

            return coincidenciaDeCodigo;
        }

        public void Registrar(Curso curso)
        {
            bool registrado = ExisteElCurso(curso.codigo);
            if (!registrado)
            {
                cursos.Add(curso);
                curso.activo = true;
                GuardarEnArchivo(); 
                return;
            }

            throw new Exception("El curso ya se encuentra registrado.");
        }

        public Curso Consultar(string codigo)
        {
            Curso cursoBuscado = null;
            if(cursos != null){
            	foreach (Curso curso in cursos)
				{
	                if (curso.codigo == codigo && curso.activo)
	                {
	                    cursoBuscado = curso;
	                    break;
	                }
	            }
            }

            if (cursoBuscado == null)
            {
                throw new Exception("El curso no se encuentra registrado.");
            }

            return cursoBuscado;
        }

        public void Actualizar(Curso curso)
        {
            int indice = 0;
            while (indice < cursos.Count)
            {
                if (cursos[indice].codigo == curso.codigo)
                {
                    cursos[indice].instructor_del_curso = curso.instructor_del_curso;
                    cursos[indice].titulo_del_curso = curso.titulo_del_curso;
                    cursos[indice].modalidad = curso.modalidad;
                    cursos[indice].horas = curso.horas;
                    cursos[indice].fecha_culminacion = curso.fecha_culminacion;
                    cursos[indice].cantidad_de_estudiantes = curso.cantidad_de_estudiantes;

                    GuardarEnArchivo(); 
                    break;
                }
                indice++;
            }
        }

        public void Eliminar(string codigo)
        {
            int indice = 0;
            while (indice < cursos.Count)
            {
                if (cursos[indice].codigo == codigo)
                {
                    cursos[indice].activo = false; 
                    GuardarEnArchivo();
                    break;
                }
                indice++;
            }
        }

    }
}
