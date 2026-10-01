namespace RelacionesEntreClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 1 - UNIVERSIDAD

            // Departamentos
            Departamento deptInformatica = new Departamento("Informática");
            Departamento deptMatematicas = new Departamento("Matemáticas");

            // Asignaturas
            Asignatura asigProgramacion =
                new Asignatura("Programación", deptInformatica);

            Asignatura asigBasesDatos =
                new Asignatura("Bases de Datos", deptInformatica);

            Asignatura asigMatematicasAplicadas =
                new Asignatura("Matemáticas Aplicadas", deptMatematicas);

            // Profesores
            Profesor profeFran = new Profesor("Fran");
            Profesor profeAlberto = new Profesor("Alberto");
            Profesor profeLaura = new Profesor("Laura");

            // Alumnos
            Alumno alumAna = new Alumno("Ana");
            Alumno alumCarlos = new Alumno("Carlos");
            Alumno alumLucia = new Alumno("Lucía");


            // Asignar asignaturas a departamentos
            deptInformatica.AnadirAsignaturaADepartamento(asigProgramacion);
            deptInformatica.AnadirAsignaturaADepartamento(asigBasesDatos);
            deptMatematicas.AnadirAsignaturaADepartamento(asigMatematicasAplicadas);


            // Asignar profesores a asignaturas
            asigProgramacion.NuevoProfesorImpartiendo(profeAlberto);
            asigProgramacion.NuevoProfesorImpartiendo(profeFran);

            asigBasesDatos.NuevoProfesorImpartiendo(profeFran);
            asigBasesDatos.NuevoProfesorImpartiendo(profeLaura);

            asigMatematicasAplicadas.NuevoProfesorImpartiendo(profeLaura);


            // Asignar asignaturas a profesores
            profeAlberto.NuevaAsignacion(asigProgramacion);

            profeFran.NuevaAsignacion(asigProgramacion);
            profeFran.NuevaAsignacion(asigBasesDatos);

            profeLaura.NuevaAsignacion(asigBasesDatos);
            profeLaura.NuevaAsignacion(asigMatematicasAplicadas);


            // Matricular alumnos en asignaturas
            alumAna.NuevaMatriculacionAsignatura(asigProgramacion);
            alumAna.NuevaMatriculacionAsignatura(asigBasesDatos);

            alumCarlos.NuevaMatriculacionAsignatura(asigBasesDatos);
            alumCarlos.NuevaMatriculacionAsignatura(asigMatematicasAplicadas);

            alumLucia.NuevaMatriculacionAsignatura(asigMatematicasAplicadas);


            // Añadir alumnos matriculados a cada asignatura
            asigProgramacion.NuevaMatriculacionAlumno(alumAna);

            asigBasesDatos.NuevaMatriculacionAlumno(alumAna);
            asigBasesDatos.NuevaMatriculacionAlumno(alumCarlos);

            asigMatematicasAplicadas.NuevaMatriculacionAlumno(alumCarlos);
            asigMatematicasAplicadas.NuevaMatriculacionAlumno(alumLucia);


            // Información de Programación
            Console.WriteLine($"La asignatura {asigProgramacion.NombreAsignatura} pertenece al departamento de {asigProgramacion.DepartamentoAsignatura.NombreDepartamento}.");

            Console.WriteLine();

            Console.WriteLine("La imparten los profesores:");
            asigProgramacion.MostrarProfesoresImpartiendo();

            Console.WriteLine();

            Console.WriteLine("Están matriculados los alumnos:");
            asigProgramacion.MostrarAlumnosMatriculados();

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();


            // Información de Bases de Datos
            Console.WriteLine($"La asignatura {asigBasesDatos.NombreAsignatura} pertenece al departamento de {asigBasesDatos.DepartamentoAsignatura.NombreDepartamento}.");

            Console.WriteLine();

            Console.WriteLine("La imparten los profesores:");
            asigBasesDatos.MostrarProfesoresImpartiendo();

            Console.WriteLine();

            Console.WriteLine("Están matriculados los alumnos:");
            asigBasesDatos.MostrarAlumnosMatriculados();

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();


            // Información de Matemáticas Aplicadas
            Console.WriteLine($"La asignatura {asigMatematicasAplicadas.NombreAsignatura} pertenece al departamento de {asigMatematicasAplicadas.DepartamentoAsignatura.NombreDepartamento}.");

            Console.WriteLine();

            Console.WriteLine("La imparten los profesores:");
            asigMatematicasAplicadas.MostrarProfesoresImpartiendo();

            Console.WriteLine();

            Console.WriteLine("Están matriculados los alumnos:");
            asigMatematicasAplicadas.MostrarAlumnosMatriculados();
        }
    }
}