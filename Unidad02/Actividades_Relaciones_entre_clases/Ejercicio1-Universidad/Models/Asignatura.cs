namespace RelacionesEntreClases
{
    /// <summary>
    /// Representa una asignatura de la universidad.
    /// Una asignatura pertenece a un departamento,
    /// puede ser impartida por varios profesores
    /// y puede tener varios alumnos matriculados.
    /// </summary>
    public class Asignatura
    {
        public string NombreAsignatura { get; set; }

        /// <summary>
        /// Profesores que imparten la asignatura.
        /// Relación N:M entre Profesor y Asignatura.
        /// </summary>
        public List<Profesor> ProfesoresImpartiendo { get; set; }

        /// <summary>
        /// Departamento al que pertenece la asignatura.
        /// Relación N:1 entre Asignatura y Departamento.
        /// </summary>
        public Departamento DepartamentoAsignatura { get; set; }

        /// <summary>
        /// Alumnos matriculados en la asignatura.
        /// Relación N:M entre Alumno y Asignatura.
        /// </summary>
        public List<Alumno> AlumnosMatriculados { get; set; }


        public Asignatura(
            string nombreAsignatura,
            Departamento departamentoAsignatura)
        {
            NombreAsignatura = nombreAsignatura;

            ProfesoresImpartiendo = new List<Profesor>();

            DepartamentoAsignatura = departamentoAsignatura;

            AlumnosMatriculados = new List<Alumno>();
        }


        /// <summary>
        /// Añade un profesor a los profesores que imparten la asignatura.
        /// </summary>
        public void NuevoProfesorImpartiendo(Profesor profesor)
        {
            ProfesoresImpartiendo.Add(profesor);
        }


        /// <summary>
        /// Añade un alumno a los alumnos matriculados en la asignatura.
        /// </summary>
        public void NuevaMatriculacionAlumno(Alumno alumno)
        {
            AlumnosMatriculados.Add(alumno);
        }


        /// <summary>
        /// Muestra los profesores que imparten la asignatura.
        /// </summary>
        public void MostrarProfesoresImpartiendo()
        {
            foreach (Profesor profesor in ProfesoresImpartiendo)
            {
                Console.WriteLine($"- {profesor.NombreProfesor}");
            }
        }


        /// <summary>
        /// Muestra los alumnos matriculados en la asignatura.
        /// </summary>
        public void MostrarAlumnosMatriculados()
        {
            foreach (Alumno alumno in AlumnosMatriculados)
            {
                Console.WriteLine($"- {alumno.NombreAlumno}");
            }
        }
    }
}