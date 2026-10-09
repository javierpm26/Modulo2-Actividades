namespace RelacionesEntreClasesVideojuego
{
    public class Equipo
    {
        public string NombreEquipo {get;set;}
        public List<Personaje> PersonajesEquipo {get;set;}
        public Equipo(string nombreequipo)
        {
            NombreEquipo = nombreequipo;
            PersonajesEquipo = new List<Personaje>();
        }

        public void AnadirPersonajeAEquipo(Personaje personaje)
        {
            PersonajesEquipo.Add(personaje);
        }

        public void MostrarPersonajesEquipo()
        {
            Console.WriteLine("Los personajes que forman parte de esta party son los siguientes: ");
            Console.WriteLine();

            foreach(Personaje personaje in PersonajesEquipo)
            {
                Console.WriteLine($"- {personaje.NombrePersonaje}");
            }
        }
    }
}