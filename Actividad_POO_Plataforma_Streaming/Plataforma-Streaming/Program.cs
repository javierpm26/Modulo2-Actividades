using Plataforma_Streaming.Entidades;

namespace PlataformaStreaming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion(
                "Faded",
                213,
                0,
                "Alan Walker",
                "Electronic Dance Music",
                false);

            Cancion cancion2 = new Cancion(
                "The Fate of Ophelia",
                227,
                0,
                "Taylor Swift",
                "Dance Pop",
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