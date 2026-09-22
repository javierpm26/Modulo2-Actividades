using Plataforma_Streaming.Entidades;

namespace PlataformaStreaming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion(
                "Faded",
                330,
                0,
                "Alan Walker",
                "EDM",
                false);

            Cancion cancion2 = new Cancion(
                "Alone",
                416,
                0,
                "Marshmello",
                "EDM",
                false);

            Podcast podcast1 = new Podcast(
                "The Wild Project",
                120,
                0,
                "Jordi Wild",
                25);

            Podcast podcast2 = new Podcast(
                "Desayuno Royale",
                50,
                0,
                "Alvaro 845",
                129);

            Audiolibro audiolibro = new Audiolibro(
                "El misterio de la ciudad",
                240,
                0,
                "Eva García",
                "Juan Magraner",
                true);

        }


    }
}