namespace RelacionesEntreClasesUniversidad
{
    /// <summary>
    /// Representa un departamento de la universidad.
    /// Un departamento puede contener varias asignaturas.
    /// </summary>
    public class Departamento
    {
        public string NombreDepartamento { get; set; }

        /// <summary>
        /// Asignaturas pertenecientes al departamento.
        /// Relación 1:N entre Departamento y Asignatura.
        /// </summary>
        public List<Asignatura> AsignaturasDepartamento { get; set; }


        public Departamento(string nombreDepartamento)
        {
            NombreDepartamento = nombreDepartamento;
            AsignaturasDepartamento = new List<Asignatura>();
        }


        /// <summary>
        /// Añade una asignatura al departamento.
        /// </summary>
        public void AnadirAsignaturaADepartamento(Asignatura asignatura)
        {
            AsignaturasDepartamento.Add(asignatura);
        }


        /// <summary>
        /// Muestra las asignaturas pertenecientes al departamento.
        /// </summary>
        public void MostrarAsignaturasAsociadas()
        {
            Console.WriteLine(
                $"El departamento {NombreDepartamento} tiene a su cargo las siguientes asignaturas:"
            );

            Console.WriteLine();

            foreach (Asignatura asignatura in AsignaturasDepartamento)
            {
                Console.WriteLine($"- {asignatura.NombreAsignatura}");
            }
        }
    }
}