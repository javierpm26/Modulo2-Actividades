using System;
using System.Collections.Generic;

namespace RelacionesEntreClases
{
    /// <summary>
    /// Representa a un alumno de la universidad.
    /// Un alumno puede estar matriculado en varias asignaturas.
    /// </summary>
    public class Alumno
    {
        /// <summary>
        /// Nombre del alumno.
        /// </summary>
        public string NombreAlumno { get; set; }

        /// <summary>
        /// Asignaturas en las que está matriculado el alumno.
        /// Representa el lado Alumno de la relación N:M entre Alumno y Asignatura.
        /// </summary>
        public List<Asignatura> AsignaturasMatriculadas { get; set; }

        /// <summary>
        /// Crea un nuevo alumno.
        /// </summary>
        /// <param name="nombreAlumno">Nombre del alumno.</param>
        public Alumno(string nombreAlumno)
        {
            NombreAlumno = nombreAlumno;
            AsignaturasMatriculadas = new List<Asignatura>();
        }

        /// <summary>
        /// Añade una asignatura a las asignaturas en las que está matriculado el alumno.
        /// </summary>
        /// <param name="asignatura">Asignatura en la que se matricula el alumno.</param>
        public void MatricularEnAsignatura(Asignatura asignatura)
        {
            if (!AsignaturasMatriculadas.Contains(asignatura))
            {
                AsignaturasMatriculadas.Add(asignatura);
            }
        }

        /// <summary>
        /// Muestra por consola las asignaturas en las que está matriculado el alumno.
        /// </summary>
        public void MostrarAsignaturasMatriculadas()
        {
            Console.WriteLine(
                $"El alumno {NombreAlumno} está matriculado en las siguientes asignaturas:"
            );

            foreach (Asignatura asignatura in AsignaturasMatriculadas)
            {
                Console.WriteLine($"- {asignatura.NombreAsignatura}");
            }
        }
    }
}