using System;
using System.Collections.Generic;

namespace RelacionesEntreClases
{
    /// <summary>
    /// Representa un departamento de la universidad.
    /// Un departamento puede tener varias asignaturas.
    /// </summary>
    public class Departamento
    {
        /// <summary>
        /// Nombre del departamento.
        /// </summary>
        public string NombreDepartamento { get; set; }

        /// <summary>
        /// Asignaturas pertenecientes al departamento.
        /// Representa el lado Departamento de la relación 1:N entre Departamento y Asignatura.
        /// </summary>
        public List<Asignatura> AsignaturasDepartamento { get; set; }

        /// <summary>
        /// Crea un nuevo departamento.
        /// </summary>
        /// <param name="nombreDepartamento">Nombre del departamento.</param>
        public Departamento(string nombreDepartamento)
        {
            NombreDepartamento = nombreDepartamento;
            AsignaturasDepartamento = new List<Asignatura>();
        }

        /// <summary>
        /// Añade una asignatura al departamento.
        /// </summary>
        /// <param name="asignatura">Asignatura perteneciente al departamento.</param>
        public void AnadirAsignatura(Asignatura asignatura)
        {
            if (!AsignaturasDepartamento.Contains(asignatura))
            {
                AsignaturasDepartamento.Add(asignatura);
            }
        }

        /// <summary>
        /// Muestra por consola las asignaturas pertenecientes al departamento.
        /// </summary>
        public void MostrarAsignaturasDepartamento()
        {
            Console.WriteLine(
                $"El departamento {NombreDepartamento} tiene las siguientes asignaturas:"
            );

            foreach (Asignatura asignatura in AsignaturasDepartamento)
            {
                Console.WriteLine($"- {asignatura.NombreAsignatura}");
            }
        }
    }
}