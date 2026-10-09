using Plataforma_Streaming.Entidades;
using PlataformaStreaming.Entidades;
using PlataformaStreaming.Interfaces;

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

            Video video1 = new Video(
                "Lo que NO te contaron de DLSS 5 (Y los videojuegos realistas)",
                2335,
                0,
                "Tecnología/Informática/Gaming",
                60,
                false);

            Video video2 = new Video(
                "¡¡Última hora del mercado de pilotos F1 2026!!",
                1867,
                0,
                "Noticias/Deportes/Motor/Automovilismo",
                30,
                false);

            Contenido[] contenidosApp = {cancion1, cancion2, podcast1, podcast2, audiolibro, video1, video2};

            Console.WriteLine("====================================");
            Console.WriteLine("CONTENIDOS DE LA APP");
            Console.WriteLine("====================================");

            foreach(Contenido contenido in contenidosApp)
            {
                Console.WriteLine(contenido.GetType().Name);
                contenido.MostrarInformacion();
                Console.WriteLine();
            }

            Console.WriteLine("====================================");
            Console.WriteLine("REPRODUCCIÓN");
            Console.WriteLine("====================================");
            
            foreach (Contenido reproducir in contenidosApp)
            {
                reproducir.Reproducir();
                Console.WriteLine();
            }

            
            Console.WriteLine("====================================");
            Console.WriteLine("DESCARGAS");
            Console.WriteLine("====================================");
            
            for(int i = 0; i < contenidosApp.Length; i++)
            {
                if(contenidosApp[i] is Cancion cancionDescargable)
                {
                    cancionDescargable.Descargar();
                    Console.WriteLine($"{cancionDescargable.Titulo} -> Descargado");
                }
                else if(contenidosApp[i] is Audiolibro audiolibroDescargable)
                {
                    audiolibroDescargable.Descargar();
                    Console.WriteLine($"{audiolibroDescargable.Titulo} -> Descargado");
                }
                else if (contenidosApp[i] is Video videoDescargable)
                {
                    Console.WriteLine($"{videoDescargable.Titulo} -> Descargado");
                }
                else
                {
                    Console.WriteLine($"{contenidosApp[i].Titulo} -> No disponible para descarga");
                }
            }
            
            /*
            for(int i = 0; i < contenidosApp.Length; i++)
            {
                if(contenidosApp[i] is IDescargable descargable)
                {
                    descargable.Descargar();
                    Console.WriteLine($"{contenidosApp[i].Titulo} -> Descargado");
                }
                else
                {
                    Console.WriteLine($"{contenidosApp[i].Titulo} -> No disponible para descarga");
                }
            }
            */

            // Escaner para pedir al usuario que contenido ya descargado desea borrar
            Console.WriteLine("Elije el elemento descargado que deseas borrar: ");
            string respuesta = Console.ReadLine() ?? "";

            // bucle for para recorrer de nuevo el array con los objetos creados
            for (int indice = 0; indice < contenidosApp.Length; indice++)
            {
                // Primer if para comprobar si lo que hay en el array tiene el atributo descargable
                if (contenidosApp[indice] is IDescargable descargable)
                {
                    // Segundo if para comparar lo que el usuario ha introducido por teclado es igual a lo que hay en el array para borrarlo
                    if (respuesta == contenidosApp[indice].Titulo)
                    {
                        Console.WriteLine($"Eliminando descarga de {contenidosApp[indice].Titulo}");
                        descargable.EliminarDescarga();
                        
                        // Tercer if para comprobar si el objeto que el usuario ha borrado se encuentra descargado.
                        if (contenidosApp[indice] is Cancion descargada)
                        {
                            Console.WriteLine($"{contenidosApp[indice].Titulo} -> Descargado: {descargada.EstaDescargado}");
                        }

                        if (contenidosApp[indice] is Video descargado)
                        {
                            Console.WriteLine($"{contenidosApp[indice].Titulo} -> Descargado: {descargado.EstaDescargado}");
                        }

                        if (contenidosApp[indice] is Audiolibro descargadoAudioLibro)
                        {
                            Console.WriteLine($"{contenidosApp[indice].Titulo} -> Descargado: {descargadoAudioLibro.EstaDescargado}");
                        }

                        
                    }
                }
            }

            // PARTE 13 - RETO OPCIONAL 
            // Añadir un nuevo tipo de contenido a nuestra plataforma de streaming el video.






            
            /*
             Esto borra todos los contenidos descargados
            for (int indice = 0; indice < contenidosApp.Length; indice++)
            {
                if (contenidosApp[indice] is IDescargable descargable)
                {
                    Console.WriteLine($"Eliminando descarga de {contenidosApp[indice].Titulo}");
                    descargable.EliminarDescarga();

                }
            } 
            */


        }

    }
}