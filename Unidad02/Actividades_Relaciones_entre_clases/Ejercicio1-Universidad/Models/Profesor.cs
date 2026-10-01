using System;
using System.Collections.Generic;

namespace RelacionesEntreClases
{
    /// <summary>
    /// Representa a un profesor de la universidad.
    /// Un profesor puede impartir varias asignaturas.
    /// </summary>
    public class Profesor
    {
        /// <summary>
        /// Nombre del profesor.
        /// </summary>
        public string NombreProfesor { get; set; }

        /// <summary>
        /// Asignaturas que imparte el profesor.
        /// Representa el lado Profesor de la relación N:M entre Profesor y Asignatura.
        /// </summary>
        public List<Asignatura> AsignaturasImpartidas { get; set; }

        /// <summary>
        /// Crea un nuevo profesor.
        /// </summary>
        /// <param name="nombreProfesor">Nombre del profesor.</param>
        public Profesor(string nombreProfesor)
        {
            NombreProfesor = nombreProfesor;
            AsignaturasImpartidas = new List<Asignatura>();
        }

        /// <summary>
        /// Añade una asignatura a las asignaturas impartidas por el profesor.
        /// </summary>
        /// <param name="asignatura">Asignatura que imparte el profesor.</param>
        public void AsignarAsignatura(Asignatura asignatura)
        {
            if (!AsignaturasImpartidas.Contains(asignatura))
            {
                AsignaturasImpartidas.Add(asignatura);
            }
        }

        /// <summary>
        /// Muestra por consola todas las asignaturas impartidas por el profesor.
        /// </summary>
        public void MostrarAsignaturasImpartidas()
        {
            Console.WriteLine(
                $"El profesor {NombreProfesor} imparte las siguientes asignaturas:"
            );

            foreach (Asignatura asignatura in AsignaturasImpartidas)
            {
                Console.WriteLine($"- {asignatura.NombreAsignatura}");
            }
        }
    }
}