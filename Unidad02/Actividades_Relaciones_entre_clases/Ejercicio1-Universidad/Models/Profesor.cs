namespace RelacionesEntreClases
{
    /// <summary>
    /// Representa un profesor de la universidad.
    /// Un profesor puede impartir varias asignaturas.
    /// </summary>
    public class Profesor
    {
        public string NombreProfesor { get; set; }

        /// <summary>
        /// Asignaturas impartidas por el profesor.
        /// Relación N:M entre Profesor y Asignatura.
        /// </summary>
        public List<Asignatura> AsignaturasImpartidas { get; set; }


        public Profesor(string nombreProfesor)
        {
            NombreProfesor = nombreProfesor;
            AsignaturasImpartidas = new List<Asignatura>();
        }


        /// <summary>
        /// Asigna una nueva asignatura al profesor.
        /// </summary>
        public void NuevaAsignacion(Asignatura asignatura)
        {
            AsignaturasImpartidas.Add(asignatura);
        }


        /// <summary>
        /// Muestra las asignaturas impartidas por el profesor.
        /// </summary>
        public void MostrarAsignaturasImpartidas()
        {
            Console.WriteLine(
                $"El profesor {NombreProfesor} imparte las asignaturas:"
            );

            Console.WriteLine();

            foreach (Asignatura asignatura in AsignaturasImpartidas)
            {
                Console.WriteLine($"- {asignatura.NombreAsignatura}");
            }
        }
    }
}