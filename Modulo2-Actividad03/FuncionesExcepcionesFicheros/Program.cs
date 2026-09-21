using System.Text.Json;
using System.Text.Encodings.Web;
using System.IO;
// BLOQUE 1 - FUNCIONES

// Ejercicio 1 - Primera función
/*static void MostrarMensaje()
{
    Console.WriteLine("Bienvenido al programa");
}

MostrarMensaje();


// Ejercicio 2 - Parámetros
static void saludar(string nombre)
{
    Console.WriteLine($"Hola {nombre}");
}

saludar("Andrea");
saludar("Javier");


// Ejercicio 3 - Función con retorno
static int Sumar(int numA, int numB)
{
    return numA + numB;
}

Console.WriteLine($"El resultado de la suma es {Sumar(5,10)}");


// Ejercicio 4 - Varios parámetros y retorno
static double CalcularMedia(double num1, double num2, double num3)
{
    return (num1 + num2 + num3) / 3;
}
Console.WriteLine($"La media es {CalcularMedia(5.0, 2.5, 3.75)}");
Console.WriteLine($"La media es {CalcularMedia(3.0, 2.5, 10)}");


// Ejercicio 5 - Variables locales y ámbito
static void MostrarAmbito()
{
    int numeroLocal = 20;

    Console.WriteLine($"El número dentro de la función es {numeroLocal}");
}

MostrarAmbito();

//Esto daría error:
//Console.WriteLine(numeroLocal);



// BLOQUE 2 - PASO DE PARÁMETROS Y RECURSIVIDAD 

// Ejercicio 6 - Paso por valor
int numero1 = 10; //Esta es la variable número original

static void Cambiar(int numero1)
{
    numero1 = 26; // Esta variable numero es una copia que usa la función
    Console.WriteLine($"Aquí numero tiene un valor de {numero1}"); // Muestra lo que vale la copia dentro de la función

}
Cambiar(numero1); // Llamar a la función hace una copia de la variable numero al que machaca su valor que es 10 a 26
Console.WriteLine($"Numero aquí vale {numero1}");


// Ejercicio 7 - ref
int numero2 = 10;

static void Cambiar2(ref int numero2)
{
    numero2 = 100;
    Console.WriteLine($"Aquí numero tiene un valor de {numero2}");

}
Cambiar2(ref numero2);
Console.WriteLine($"Numero aquí vale {numero2}");


// Ejercicio 8 - out

int numero3 = 5;

static void Cambiar3(int numero3, out int nDoble, out int nTriple)
{
    nDoble = numero3 * 2;
    nTriple = numero3 * 3;

    Console.WriteLine($"El doble de {numero3} es {nDoble}");
    Console.WriteLine($"El triple de {numero3} es {nTriple}");

}
Cambiar3(numero3, out int nDoble, out int nTriple);
Console.WriteLine(numero3);


// Ejercicio 9 - Recursividad
static void cuentaAtras(int numero)
{
    if (numero <= 0)
    {
        return;
    }
    Console.WriteLine(numero);
    cuentaAtras(numero -1);
}

cuentaAtras(20);



// BLOQUE 3 - EXCEPCIONES Y VALIDACION

// Ejercicio 10 - Detectar una excepción
string letras = "abc";
try
{
    int numConvertido = int.Parse(letras);
}
catch
{
    Console.WriteLine("No se puede convertir un tipo string a int.");
}


// Ejercicio 11 - Introducción segura de datos
try
{
    Console.WriteLine("Introduce tu edad: ");
    int edadTry = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine($"Ok, tu edad es {edadTry}");

}
catch
{
    Console.WriteLine("Error: Se ha introducido un dato de tipo String, tienes que introducir tu edad con un número entero INT");
}
finally
{
    Console.WriteLine("Operación terminada");
}


// Ejercicio 12 - Validación con throw
int edad = -5;

static void ValidarEdad(int edad)
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

try
{
    ValidarEdad(edad);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


// Ejercicio 13 - finally
static void validadEdad2(int edad)
{
    if (edad > 0)
    {
        Console.WriteLine($"Ok, tu edad es {edad}");
    }else
    {
        throw new Exception("Error: Tu edad no puede ser un numero negativo");
    }
}

try
{
    Console.WriteLine("Introduce tu edad:");
    int edad2 = int.Parse(Console.ReadLine() ?? "");
    validadEdad2(edad2);

}
catch (Exception excepcion)
{
    Console.WriteLine(excepcion.Message);
}

finally
{
    Console.WriteLine("El programa se ha terminado");
}



// BLOQUE 4 - FICHEROS Y DIRECTORIOS

// Ejercicio 14 - Crear un directorio y un archivo
bool existeCarpeta = Directory.Exists("datos");
if(existeCarpeta == true)
{
    Console.WriteLine("La carpeta ya está creada.");
}
else
{
    Directory.CreateDirectory("datos");
    string ruta = Path.Combine("datos", "mensaje.txt");
    File.WriteAllText(ruta, "Hola desde C#");
}


// Ejercicio 15 - Leer y modificar un archivo
// Leer un archivo

string ruta2 = Path.Combine("datos", "mensaje.txt"); // Pasarle la ruta donde está el archivo
string archivo = File.ReadAllText(ruta2); // Una vez obtenido el archivo, lo leemos y se guarda en la variable
Console.WriteLine(archivo); // Mostrar por pantalla el contenido del archivo

// Agregar contenido al archivo

File.AppendAllText(ruta2, Environment.NewLine + "Adios desde C#"); // File.Appen

Console.WriteLine(archivo);


// Ejercicio 16 - CSV
string rutaArchivoCSV = Path.Combine("datos", "personas.csv");

string[] lineasArchivoCSV = File.ReadAllLines(rutaArchivoCSV);

string[] datosPersonas = new string[0]; // Inicializamos el array de datosPersonas como un array vacío

Console.WriteLine($"ARCHIVO {rutaArchivoCSV}: \n"); // Para mostrar un encabezado con el nombre del archivo CSV que se está leyendo

foreach (string linea in lineasArchivoCSV)
{
    
    Console.WriteLine($"Línea: {linea}"); // Mostrar la línea leída del archivo CSV
    datosPersonas = linea.Split(';');
    



    // Mostrar los datos de la primera persona del archivo CSV
    Console.WriteLine($"Nombre: {datosPersonas[0]}"); // Obtener el primer elemento del array que es el nombre
    Console.WriteLine($"Edad: {datosPersonas[1]}"); // Obtener el segundo elemento del array que es la edad
    Console.WriteLine($"Ciudad: {datosPersonas[2]}"); // Obtener el tercer elemento del array que es la ciudad

    Console.WriteLine("-----------------------------");

}

// BLOQUE 5 - JSON


// Ejercicio 17 - Crear un JSON
var persona = new
{
    Nombre = "Beatriz",
    Edad = 27,
    Ciudad = "Socuéllamos"
};

var opciones = new JsonSerializerOptions
{
    WriteIndented = true,
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    
};

string json = JsonSerializer.Serialize(persona, opciones);
Console.WriteLine(json);


// Ejercicio 18 - Leer JSON desde un archivo
File.WriteAllText("persona.json", json);

string texto = File.ReadAllText("persona.json");
Console.WriteLine(texto);


var personaLeida = JsonSerializer.Deserialize<Persona>(texto);

if (personaLeida == null)
{
    throw new Exception("No se pudo deserializar el JSON");
}

Console.WriteLine(personaLeida.Nombre);
Console.WriteLine(personaLeida.Edad);
Console.WriteLine(personaLeida.Ciudad);*/



// BLOQUE 6 - STREAMS
// Ejercicio 19 - StreamWriter y StreamReader

using (StreamWriter writer = new StreamWriter("notas.txt"))
{
    writer.WriteLine("Andrea - 8");
    writer.WriteLine("Luis - 6");
    writer.WriteLine("Carlos - 9");
    writer.WriteLine("Marta - 7");
}


using (StreamReader reader = new StreamReader("notas.txt"))
{
    string linea = "";

    while ((linea = reader.ReadLine()) != null)
    {
        Console.WriteLine(linea);
    }
}





