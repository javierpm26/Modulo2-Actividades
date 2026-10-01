using System;
using System.Collections.Generic;

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
        /// <summary>
        /// Nombre de la asignatura.
        /// </summary>
        public string NombreAsignatura { get; set; }

        /// <summary>
        /// Profesores que imparten la asignatura.
        /// Representa el lado Asignatura de la relación N:M entre Profesor y Asignatura.
        /// </summary>
        public List<Profesor> ProfesoresImpartiendo { get; set; }

        /// <summary>
        /// Departamento al que pertenece la asignatura.
        /// Representa el lado Asignatura de la relación 1:N entre Departamento y Asignatura.
        /// </summary>
        public Departamento DepartamentoAsignatura { get; set; }

        /// <summary>
        /// Alumnos matriculados en la asignatura.
        /// Representa el lado Asignatura de la relación N:M entre Alumno y Asignatura.
        /// </summary>
        public List<Alumno> AlumnosMatriculados { get; set; }

        /// <summary>
        /// Crea una nueva asignatura y la asocia a un departamento.
        /// </summary>
        /// <param name="nombreAsignatura">Nombre de la asignatura.</param>
        /// <param name="departamentoAsignatura">Departamento al que pertenece la asignatura.</param>
        public Asignatura(
            string nombreAsignatura,
            Departamento departamentoAsignatura)
        {
            NombreAsignatura = nombreAsignatura;
            DepartamentoAsignatura = departamentoAsignatura;

            ProfesoresImpartiendo = new List<Profesor>();
            AlumnosMatriculados = new List<Alumno>();

            // Se añade automáticamente la asignatura al departamento.
            departamentoAsignatura.AnadirAsignatura(this);
        }

        /// <summary>
        /// Asigna un profesor a la asignatura.
        /// Mantiene actualizados los dos lados de la relación Profesor-Asignatura.
        /// </summary>
        /// <param name="profesor">Profesor que impartirá la asignatura.</param>
        public void AsignarProfesor(Profesor profesor)
        {
            if (!ProfesoresImpartiendo.Contains(profesor))
            {
                ProfesoresImpartiendo.Add(profesor);
            }

            // "this" representa esta asignatura concreta.
            profesor.AsignarAsignatura(this);
        }

        /// <summary>
        /// Matricula un alumno en la asignatura.
        /// Mantiene actualizados los dos lados de la relación Alumno-Asignatura.
        /// </summary>
        /// <param name="alumno">Alumno que se matricula en la asignatura.</param>
        public void MatricularAlumno(Alumno alumno)
        {
            if (!AlumnosMatriculados.Contains(alumno))
            {
                AlumnosMatriculados.Add(alumno);
            }

            // "this" representa esta asignatura concreta.
            alumno.MatricularEnAsignatura(this);
        }

        /// <summary>
        /// Muestra por consola los profesores que imparten la asignatura.
        /// </summary>
        public void MostrarProfesoresImpartiendo()
        {
            Console.WriteLine("Profesores que imparten la asignatura:");

            foreach (Profesor profesor in ProfesoresImpartiendo)
            {
                Console.WriteLine($"- {profesor.NombreProfesor}");
            }
        }

        /// <summary>
        /// Muestra por consola los alumnos matriculados en la asignatura.
        /// </summary>
        public void MostrarAlumnosMatriculados()
        {
            Console.WriteLine("Alumnos matriculados:");

            foreach (Alumno alumno in AlumnosMatriculados)
            {
                Console.WriteLine($"- {alumno.NombreAlumno}");
            }
        }

        /// <summary>
        /// Muestra la información completa de la asignatura:
        /// nombre, departamento, profesores y alumnos matriculados.
        /// </summary>
        public void MostrarInformacionAsignatura()
        {
            Console.WriteLine("======================================");
            Console.WriteLine($"Asignatura: {NombreAsignatura}");
            Console.WriteLine(
                $"Departamento: {DepartamentoAsignatura.NombreDepartamento}"
            );
            Console.WriteLine();

            MostrarProfesoresImpartiendo();

            Console.WriteLine();

            MostrarAlumnosMatriculados();
        }
    }
}