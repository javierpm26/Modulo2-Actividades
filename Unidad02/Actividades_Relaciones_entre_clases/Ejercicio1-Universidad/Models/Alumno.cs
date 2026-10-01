namespace RelacionesEntreClases
{
    /// <summary>
    /// Representa un alumno de la universidad.
    /// Un alumno puede estar matriculado en varias asignaturas.
    /// </summary>
    public class Alumno
    {
        public string NombreAlumno { get; set; }

        /// <summary>
        /// Asignaturas en las que está matriculado el alumno.
        /// Relación N:M entre Alumno y Asignatura.
        /// </summary>
        public List<Asignatura> AsignaturasMatriculadas { get; set; }


        public Alumno(string nombreAlumno)
        {
            NombreAlumno = nombreAlumno;
            AsignaturasMatriculadas = new List<Asignatura>();
        }


        /// <summary>
        /// Matricula al alumno en una asignatura.
        /// </summary>
        public void NuevaMatriculacionAsignatura(Asignatura asignatura)
        {
            AsignaturasMatriculadas.Add(asignatura);
        }


        /// <summary>
        /// Muestra las asignaturas en las que está matriculado el alumno.
        /// </summary>
        public void MostrarAsignaturasMatriculadas()
        {
            Console.WriteLine(
                $"El alumno {NombreAlumno} está matriculado en las siguientes asignaturas:"
            );

            Console.WriteLine();

            foreach (Asignatura asignatura in AsignaturasMatriculadas)
            {
                Console.WriteLine($"- {asignatura.NombreAsignatura}");
            }
        }
    }
}