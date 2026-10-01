using System.Text.Json;
namespace FuncionesExcepcionesFicheros
{
    public static class Utilities
    {
        // BLOQUE 1 - FUNCIONES

        // Ejercicio 1 - Primera función
        public static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido al programa");
        }


        // Ejercicio 2 - Parámetros
        public static void saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }


        // Ejercicio 3 - Función con retorno
        public static int Sumar(int numA, int numB)
        {
            return numA + numB;
        }


        // Ejercicio 4 - Varios parámetros y retorno
        public static double CalcularMedia(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }


        // Ejercicio 5 - Variables locales y ámbito
        public static void MostrarAmbito()
        {
            int numeroLocal = 20;

            Console.WriteLine($"El número dentro de la función es {numeroLocal}");
        }


        // BLOQUE 2 - PASO DE PARÁMETROS Y RECURSIVIDAD

        // Ejercicio 6 - Paso por valor
        public static void Cambiar(int numero1)
        {
            numero1 = 26; // Esta variable numero es una copia que usa la función

            Console.WriteLine($"Aquí numero tiene un valor de {numero1}"); // Muestra lo que vale la copia dentro de la función
        }


        // Ejercicio 7 - ref
        public static void Cambiar2(ref int numero2)
        {
            numero2 = 100;

            Console.WriteLine($"Aquí numero tiene un valor de {numero2}");
        }


        // Ejercicio 8 - out
        public static void Cambiar3(int numero3, out int nDoble, out int nTriple)
        {
            nDoble = numero3 * 2;

            nTriple = numero3 * 3;

            Console.WriteLine($"El doble de {numero3} es {nDoble}");

            Console.WriteLine($"El triple de {numero3} es {nTriple}");
        }


        // Ejercicio 9 - Recursividad
        public static void cuentaAtras(int numero)
        {
            if (numero <= 0)
            {
                return;
            }

            Console.WriteLine(numero);

            cuentaAtras(numero - 1);
        }


        // BLOQUE 3 - EXCEPCIONES Y VALIDACION

        // Ejercicio 12 - Validación con throw
        public static void ValidarEdad(int edad)
        {
            if (edad > 0)
            {
                Console.WriteLine("La edad es positiva.");
            }
            else
            {
                throw new Exception("Error: La edad no puede ser negativa.");
            }
        }


        // Ejercicio 13 - finally
        public static void validadEdad2(int edad)
        {
            if (edad > 0)
            {
                Console.WriteLine($"Ok, tu edad es {edad}");
            }
            else
            {
                throw new Exception("Error: Tu edad no puede ser un numero negativo");
            }
        }

        // Ejercicio 20 - Gestor de datos
        // 1. Crear una carpeta
        public static void CrearDirectorio()
        {
            bool existeCarpeta = Directory.Exists("datos");

            if (existeCarpeta == true)
            {
                Console.WriteLine("La carpeta ya está creada");
            }
            else
            {
                Directory.CreateDirectory("datos");
                Console.WriteLine("Carpeta creada correctamente");
            }

        }

        // 2. Crear un archivo CSV
        public static string CrearCSV()
        {
            string rutaCSV = Path.Combine("datos", "personas.csv");

            string contenidoCSV = "nombre;edad" + Environment.NewLine + "Andrea;25" + Environment.NewLine + "Luis;31" + Environment.NewLine + "Carlos;22" + Environment.NewLine + "User;-20";

            try
            {
                File.WriteAllText(rutaCSV, contenidoCSV);
                Console.WriteLine("Archivo CSV creado correctamente");

                return rutaCSV;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el archivo: {ex.Message}");

                throw;
            }
        }

        // 3. Leer el CSV
        public static void LeerCSV(string rutaCSV)
        {
            using (StreamReader reader = new StreamReader(rutaCSV))
            {
                reader.ReadLine();

                while (true)
                {
                    var linea = reader.ReadLine();

                    if (linea == null)
                    {
                        break;
                    }

                    string[] datosPersonas = linea.Split(';');

                    Console.WriteLine($"Nombre: {datosPersonas[0]}");
                    Console.WriteLine($"Edad: {datosPersonas[1]}");
                }
            }
        }

        // 4. Validad la edad

        public static bool ValidarEdadCSV(string rutaCSV)
        {

            string[] lineas = File.ReadAllLines(rutaCSV);
            bool edadValida = true;

            foreach (string linea in lineas.Skip(1))
            {
                int edad = Convert.ToInt32(linea.Split(";")[1]);
                if (edad < 0)
                {
                    edadValida = false;
                }
            }
            return edadValida;
        }


        // 5. Crear un objeto

        public static void crearObjetos(string rutaCSV)
        {
            var infoPersonas = File.ReadLines(rutaCSV);

            foreach (string linea in infoPersonas.Skip(1))
            {
                string[] columnas = linea.Split(";");

                var persona = new
                {
                    Nombre = columnas[0],
                    Edad = columnas[1]
                };

                Console.WriteLine($"Nombre = {persona.Nombre} Edad = {persona.Edad}");
            }
        }


        // 6. Guardar los datos en JSON

        public static void crearObjetos2(string rutaCSV)
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var infoPersonas = File.ReadLines(rutaCSV);

            foreach (string infoPersona in infoPersonas.Skip(1))
            {
                string[] columnas = infoPersona.Split(";");

                var datosPersona = new
                {
                    Nombre = columnas[0],
                    Edad = columnas[1]
                };

                string json = JsonSerializer.Serialize(datosPersona, opciones);

                Console.WriteLine(json);
            }

        }



    }
}
