namespace RelacionesEntreClasesVideojuego
{
    public class Partida
    {
        public string NombrePartida {get;set;}
        public List<Jugador> JugadoresPartida {get;set;}
        public Partida(string nombrepartida)
        {
            NombrePartida = nombrepartida;
            JugadoresPartida = new List<Jugador>();
        }
        
        public void AnadirJugadorAPartida(Jugador jugador)
        {
            JugadoresPartida.Add(jugador);
        }
        public void MostrarJugadoresPartida()
        {
            Console.WriteLine("Los jugadores que forman parte de esta partida son los siguientes: ");
            Console.WriteLine();

            foreach(Jugador jugador in JugadoresPartida)
            {
                Console.WriteLine($"- {jugador.NombreJugador}");
            }
        }
    }
}