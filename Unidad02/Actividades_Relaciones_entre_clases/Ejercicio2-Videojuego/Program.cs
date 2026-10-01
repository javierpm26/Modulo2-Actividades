namespace RelacionesEntreClasesVideojuego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 2 - VIDEOJUEGO

            // Objetos
            Objeto espadaHierro = new Objeto(
                "Espada de hierro",
                TipoObjeto.Arma,
                1
            );

            Objeto armaduraAcero = new Objeto(
                "Armadura de acero",
                TipoObjeto.Armadura,
                1
            );

            Objeto pocionVida = new Objeto(
                "Poción de vida",
                TipoObjeto.Pocion,
                3
            );

            Objeto bastonMagico = new Objeto(
                "Bastón mágico",
                TipoObjeto.Arma,
                1
            );

            Objeto pocionMana = new Objeto(
                "Poción de maná",
                TipoObjeto.Pocion,
                2
            );

            Objeto arco = new Objeto(
                "Arco",
                TipoObjeto.Arma,
                1
            );

            Objeto armaduraCuero = new Objeto(
                "Armadura de cuero",
                TipoObjeto.Armadura,
                1
            );


            // Personajes
            Guerrero guerreroDarian = new Guerrero(
                85,
                "Darian",
                150,
                12
            );

            Mago magoElian = new Mago(
                120,
                "Elian",
                90,
                11
            );

            Arquero arqueroLyra = new Arquero(
                30,
                "Lyra",
                110,
                10
            );


            // Añadir objetos a personajes
            guerreroDarian.AnadirObjeto(espadaHierro);
            guerreroDarian.AnadirObjeto(armaduraAcero);
            guerreroDarian.AnadirObjeto(pocionVida);

            magoElian.AnadirObjeto(bastonMagico);
            magoElian.AnadirObjeto(pocionMana);

            arqueroLyra.AnadirObjeto(arco);
            arqueroLyra.AnadirObjeto(armaduraCuero);
            arqueroLyra.AnadirObjeto(pocionVida);


            // Jugadores
            Jugador jugadorAna = new Jugador(
                "Ana",
                guerreroDarian
            );

            Jugador jugadorCarlos = new Jugador(
                "Carlos",
                magoElian
            );

            Jugador jugadorLucia = new Jugador(
                "Lucía",
                arqueroLyra
            );


            // Equipos
            Equipo equipoRojo = new Equipo("Equipo Rojo");
            Equipo equipoAzul = new Equipo("Equipo Azul");


            // Añadir personajes a equipos
            equipoRojo.AnadirPersonajeAEquipo(guerreroDarian);
            equipoRojo.AnadirPersonajeAEquipo(magoElian);

            equipoAzul.AnadirPersonajeAEquipo(arqueroLyra);


            // Partida
            Partida partidaPrincipal = new Partida("Batalla del Bosque");


            // Añadir jugadores a la partida
            partidaPrincipal.AnadirJugadorAPartida(jugadorAna);
            partidaPrincipal.AnadirJugadorAPartida(jugadorCarlos);
            partidaPrincipal.AnadirJugadorAPartida(jugadorLucia);


            // Información del guerrero
            guerreroDarian.MostrarInformacionPersonaje();

            Console.WriteLine();

            Console.WriteLine("Habilidad:");
            guerreroDarian.HabilidadPersonaje();

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();


            // Información del mago
            magoElian.MostrarInformacionPersonaje();

            Console.WriteLine();

            Console.WriteLine("Habilidad:");
            magoElian.HabilidadPersonaje();

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();


            // Información del arquero
            arqueroLyra.MostrarInformacionPersonaje();

            Console.WriteLine();

            Console.WriteLine("Habilidad:");
            arqueroLyra.HabilidadPersonaje();

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();


            // Información de los jugadores
            jugadorAna.MostrarInformacionJugador();
            jugadorCarlos.MostrarInformacionJugador();
            jugadorLucia.MostrarInformacionJugador();

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();


            // Personajes de los equipos
            Console.WriteLine($"Personajes del equipo {equipoRojo.NombreEquipo}:");
            equipoRojo.MostrarPersonajesEquipo();

            Console.WriteLine();

            Console.WriteLine($"Personajes del equipo {equipoAzul.NombreEquipo}:");
            equipoAzul.MostrarPersonajesEquipo();

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();


            // Jugadores de la partida
            Console.WriteLine($"Partida: {partidaPrincipal.NombrePartida}");
            partidaPrincipal.MostrarJugadoresPartida();
        }
    }
}