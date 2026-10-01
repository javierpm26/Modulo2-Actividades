using System;

namespace RelacionesEntreClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =============================================
            // EJERCICIO 1 - UNIVERSIDAD
            // =============================================

            // MER / RELACIONES:
            // Profesor N:M Asignatura
            // Alumno N:M Asignatura
            // Departamento 1:N Asignatura

            // =============================================
            // CREAR DEPARTAMENTOS
            Departamento departamentoInformatica = new Departamento("Informática");Departamento departamentoMatematicas = new Departamento("Matemáticas");

            // =============================================
            // CREAR ASIGNATURAS
            // Cada asignatura pertenece a un único departamento.
            Asignatura asignaturaProgramacion = new Asignatura(
                    "Programación",
                    departamentoInformatica
                );

            Asignatura asignaturaBasesDatos =
                new Asignatura(
                    "Bases de Datos",
                    departamentoInformatica
                );

            Asignatura asignaturaMatematicasAplicadas =
                new Asignatura(
                    "Matemáticas Aplicadas",
                    departamentoMatematicas
                );

            // =============================================
            // CREAR PROFESORES
            Profesor profesorFran = new Profesor("Fran");
            Profesor profesorAlberto = new Profesor("Alberto");
            Profesor profesorLaura = new Profesor("Laura");

            // =============================================
            // CREAR ALUMNOS
            Alumno alumnoAna = new Alumno("Ana");
            Alumno alumnoCarlos = new Alumno("Carlos");
            Alumno alumnoLucia = new Alumno("Lucía");


            // =============================================
            // RELACIÓN PROFESOR - ASIGNATURA

            // Relación N:M:
            // un profesor puede impartir varias asignaturas
            // y una asignatura puede ser impartida por varios profesores.

            asignaturaProgramacion.AsignarProfesor(profesorAlberto);
            asignaturaProgramacion.AsignarProfesor(profesorFran);

            asignaturaBasesDatos.AsignarProfesor(profesorFran);
            asignaturaBasesDatos.AsignarProfesor(profesorLaura);

            asignaturaMatematicasAplicadas.AsignarProfesor(profesorLaura);

            // =============================================
            // RELACIÓN ALUMNO - ASIGNATURA

            // Relación N:M:
            // un alumno puede matricularse en varias asignaturas
            // y una asignatura puede tener varios alumnos.

            asignaturaProgramacion.MatricularAlumno(alumnoAna);

            asignaturaBasesDatos.MatricularAlumno(alumnoAna);
            asignaturaBasesDatos.MatricularAlumno(alumnoCarlos);

            asignaturaMatematicasAplicadas.MatricularAlumno(alumnoCarlos);
            asignaturaMatematicasAplicadas.MatricularAlumno(alumnoLucia);

            // =============================================
            // MOSTRAR INFORMACIÓN DE LAS ASIGNATURAS

            // Cumple el requisito:
            // "Mostrar la información de una asignatura
            // y las personas relacionadas con ella."

            asignaturaProgramacion.MostrarInformacionAsignatura();

            Console.WriteLine();

            asignaturaBasesDatos.MostrarInformacionAsignatura();

            Console.WriteLine();

            asignaturaMatematicasAplicadas.MostrarInformacionAsignatura();


            // =============================================
            // COMPROBAR LAS RELACIONES DESDE EL OTRO LADO DE LA CLASE

            Console.WriteLine();
            Console.WriteLine("COMPROBACIÓN DESDE PROFESOR");
            Console.WriteLine();

            profesorFran.MostrarAsignaturasImpartidas();


            Console.WriteLine();
            Console.WriteLine("COMPROBACIÓN DESDE ALUMNO");
            Console.WriteLine();

            alumnoAna.MostrarAsignaturasMatriculadas();


            Console.WriteLine();
            Console.WriteLine("COMPROBACIÓN DESDE DEPARTAMENTO");
            Console.WriteLine();

            departamentoInformatica.MostrarAsignaturasDepartamento();
        }
    }
}