namespace RelacionesEntreClasesVideojuego
{
    public class Jugador
    {
        public string NombreJugador {get;set;}
        public Personaje PersonajeControlado {get;set;}

        public Jugador(string nombrejugador, Personaje personajecontrolado)
        {
            NombreJugador = nombrejugador;
            PersonajeControlado = personajecontrolado;
        }

        public void MostrarInformacionJugador()
        {
            Console.WriteLine($"Este jugador se llama {NombreJugador}, y tiene el control del personaje {PersonajeControlado.NombrePersonaje}.");
        }
    }
}