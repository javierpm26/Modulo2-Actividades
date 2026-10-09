// NIVEL 1 - IF

// Ejercicio 1 - Mayor de edad
Console.WriteLine("Introduce tu edad: ");
int edad = int.Parse(Console.ReadLine() ?? "");

if (edad >= 18)
{
    Console.WriteLine("Es mayor de edad");
}
else
{
    Console.WriteLine("Es menor de edad");
}


// Ejercicio 2 - Número positivo
Console.WriteLine("Introduce un número entero: ");
int numero = int.Parse(Console.ReadLine() ?? "");

if (numero > 0)
{
    Console.WriteLine($"El número {numero} es mayor que 0");
}
else if (numero == 0)
{
    Console.WriteLine("El número es 0");
}
else
{
    Console.WriteLine($"El número es negativo");
}


// Ejercicio 3 - Nota aprobada
Console.WriteLine("Introduce tu nota: ");
int nota = int.Parse(Console.ReadLine() ?? "");

if (nota > 10 || nota < 0)
{
    Console.WriteLine("Nota no válida");
}
else if (nota >= 5)
{
    Console.WriteLine("Estás aprobado");
}
else
{
    Console.WriteLine("Estás suspenso");
}


// Ejercicio 4 - Temperatura
Console.WriteLine("Dime una temperatura: ");
decimal temperatura = decimal.Parse(Console.ReadLine() ?? "");

if (temperatura > 30)
{
    Console.WriteLine($"Hay {temperatura} grados, hace mucho calor");
}
else
{
    Console.WriteLine($"Hay {temperatura} grados, hace fresquito");
}



// NIVEL 2 - IF + ELSE

// Ejercicio 5 - Par o impar
Console.WriteLine("Introduce un número entero: ");
int numero2 = int.Parse(Console.ReadLine() ?? "");

if (numero2%2 == 0)
{
    Console.WriteLine("El número es par.");
}
else
{
    Console.WriteLine("El número es impar.");
}


// Ejercicio 6 - Positivo, negativo o cero
Console.WriteLine("Introduce un número entero:");
int numero3 = int.Parse(Console.ReadLine() ?? "");

if (numero3 > 0)
{
    Console.WriteLine($"{numero3} es un número positivo");
}
else if (numero3 == 0)
{
    Console.WriteLine($"{numero3} es cero (0)");
}
else
{
    Console.WriteLine($"{numero3} es un número negativo");
}


// Ejercicio 7 - Contraseña
string contrasenaCorrecta = "1234";

Console.WriteLine("Introduce la contraseña: ");
string contrasena = Console.ReadLine() ?? "";

if (contrasena == contrasenaCorrecta)
{
    Console.WriteLine("Contraseña correcta");
}
else
{
    Console.WriteLine("Contraseña incorrecta");
}


// Ejercicio 8 - Calificación
Console.WriteLine("Dame una nota: ");
decimal nota2 = decimal.Parse(Console.ReadLine() ?? "");

if (nota2 < 5)
{
    Console.WriteLine("Suspenso");
}
else if (nota2 < 7)
{
    Console.WriteLine("Aprobado");
}
else if (nota2 < 9)
{
    Console.WriteLine("Notable");
}
else if (nota2 < 10 || nota2 == 10)
{
    Console.WriteLine("Sobresaliente");
}
else
{
    Console.WriteLine("Nota no válida");
}


// Ejercicio 9 - Edad
Console.WriteLine("Introduce tu edad: ");
int edad2 = int.Parse(Console.ReadLine() ?? "");

if (edad2 < 13)
{
    Console.WriteLine("Eres un niño");
}
else if (edad2 <= 17)
{
    Console.WriteLine("Eres un adolescente");
} 
else if (edad2 <= 64)
{
    Console.WriteLine("Eres un adulto");
}
else if (edad2 <= 100)
{
    Console.WriteLine("Eres una persona mayor");
}
else
{
    Console.WriteLine("Edad inválida");
}


// Ejercicio 10 - Precio con descuento
decimal precioSinDescuento = 0m;
decimal descuento = 0m;
decimal precioFinal = 0m;

Console.WriteLine("Precio del producto");
precioSinDescuento = decimal.Parse(Console.ReadLine() ?? "");

if (precioSinDescuento < 50)
{
    Console.WriteLine("El precio es menor que 50€: Sin descuento");
}
else if (precioSinDescuento < 100)
{
    descuento = (precioSinDescuento * 5.00m ) / 100;
    precioFinal = precioSinDescuento - descuento;
    Console.WriteLine($"El precio es {precioSinDescuento} se le aplica un 5% y se queda en {precioFinal}");
}
else
{
    descuento = (precioSinDescuento * 10.00m) / 100;
    precioFinal = precioSinDescuento - descuento;
    Console.WriteLine($"El precio es {precioSinDescuento} se le aplica UN 10% y se queda en {precioFinal}.");
}



//  NIVEL 4 - SWITCH

// Ejercicio 11 - Día de la semana
Console.WriteLine("Introduce un número del 1 al 7: ");
int numDia = int.Parse(Console.ReadLine() ?? "");

switch (numDia)
{
    case 1:
        Console.WriteLine("El día 1 de la semana es Lunes");
        break;
    case 2:
        Console.WriteLine("El día 2 de la semana es Martes");
        break;
    case 3:
        Console.WriteLine("El día 3 de la semana es Miércoles");
        break;
    case 4:
        Console.WriteLine("El día 4 de la semana es Jueves");
        break;
    case 5:
        Console.WriteLine("El día 5 de la semana es Viernes");
        break;
    case 6:
        Console.WriteLine("El día 6 de la semana es Sábado");
        break;
    case 7:
        Console.WriteLine("El día 7 de la semana es Domingo");
        break;
    default:
        Console.WriteLine("Día no válido");
        break;
}


// Ejercicio 12 - Menú
int opcionUsuario = 0;

Console.WriteLine("1. Crear\n2. Consultar\n3. Modificar\n4. Eliminar");

Console.Write("Escribe una opción:");
opcionUsuario = int.Parse(Console.ReadLine() ?? "");


switch (opcionUsuario)
{
    case 1:
        Console.WriteLine("Has elegido CREAR");
        break;
    case 2:
        Console.WriteLine("Has elegido CONSULTAR");
        break;
    case 3:
        Console.WriteLine("Has elegido MODIFICAR");
        break;
    case 4:
        Console.WriteLine("Has elegido ELIMINAR");
        break;
    default:
        Console.WriteLine("¡OPCIÓN NO VÁLIDA!");
        break;
}


// Ejercicio 13 - Operación matemática
Console.WriteLine("Introduce un número: ");
int numA = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Introduce otro número: ");
int numB = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Introduce la operación que deseas realizar (+, -, *, /): ");
string operacionAritm = Console.ReadLine() ?? "";

switch (operacionAritm)
{
    case "+":
        Console.WriteLine($"El resultado de la suma es {numA + numB}");
        break;
    case "-":
        Console.WriteLine($"El resultado de la resta es {numA - numB}");
        break;
    case "*":
        Console.WriteLine($"El resultado de la multiplicación es {numA * numB}");
        break;
    case "/":
        Console.WriteLine($"El resultado de la división es {numA / numB}");
        break;
    default:
        Console.WriteLine("Operación no válida");
        break;
}


// Ejercicio 14 - Meses
Console.WriteLine("Introduce un número: ");
int numMes = int.Parse(Console.ReadLine() ?? "");

switch(numMes)
{
    case 1:
        Console.WriteLine("1. ==> ENERO");
        break;
    case 2:
        Console.WriteLine("2. ==> FEBRERO");
        break;
    case 3:
        Console.WriteLine("3. ==> MARZO");
        break;
    case 4:
        Console.WriteLine("4. ==> ABRIL");
        break;
    case 5:
        Console.WriteLine("5. ==> MAYO");
        break;
    case 6:
        Console.WriteLine("6. ==> JUNIO");
        break;
    case 7:
        Console.WriteLine("7. ==> JULIO");
        break;
    case 8:
        Console.WriteLine("8. ==> AGOSTO");
        break;
    case 9:
        Console.WriteLine("9. ==> SEPTIEMBRE");
        break;
    case 10:
        Console.WriteLine("10. ==> OCTUBRE");
        break;
    case 11:
        Console.WriteLine("11. ==> NOVIEMBRE");
        break;
    case 12:
        Console.WriteLine("12. ==> DICIEMBRE");
        break;
    default:
        Console.WriteLine("¡¡OPCIÓN NO VÁLIDA!!");
        break;
}



// NIVEL 5 - SWITCH EXPRESSIONS

// Ejercicio 15 - Traducir una opción
Console.WriteLine("Introduce un número del 1 al 3: ");
int numOpcion = int.Parse(Console.ReadLine() ?? "");

string resultado = numOpcion switch
{
    1 => "Bajo",
    2 => "Medio",
    3 => "Alto",
    _ => "No válido"
};

Console.WriteLine($"Has elegido la opción {resultado}");


// Ejercicio 16 - Día abreviado
Console.Write("1=>Lun\n2=>Mar\n3=>Mié\n4=>Jue\n5=>Vie\n6=>Sáb\n7=>Dom\n");

Console.WriteLine("Introduce un número (1-7): ");
int numDia2 = int.Parse(Console.ReadLine() ?? "");

string diasSemana = numDia2 switch
{
    1 => "Lun",
    2 => "Mar",
    3 => "Mié",
    4 => "Jue",
    5 => "Vie",
    6 => "Sáb",
    7 => "Dom",
    _ => "???"
};

Console.WriteLine($" Has elegido: {diasSemana}");



// NIVEL 6 - PATTERN MATCHING

// Ejercicio 17 - Comprobar tipo
object dato = 25;
if (dato is int)
{
    Console.WriteLine("El número introducido es de tipo entero.");
}


// Ejercicio 18 - Comprobar tipo y valor
object datoA = 25;

if (datoA is int numeroEntero && numeroEntero > 18)
{
    Console.WriteLine($"{datoA} es un número entero y es mayor que 18");
}
else
{
    Console.WriteLine($"{datoA} NO es un número entero y tampoco es mayor a 18");
}


// Ejercicio 19 - Analizar diferentes datos
object dato1 = 25;
object dato2 = "Hola";
object dato3 = 8.5;

// dato1
if (dato1 is int)
{
    Console.WriteLine("La variable object dato1 es de tipo entero.");
}
else if (dato1 is string)
{
    Console.WriteLine("La variable object dato1 es de tipo string.");
}
else if (dato1 is double)
{
    Console.WriteLine("La variable object dato1 es de tipo double.");
}
else
{
    Console.WriteLine("La variable object dato1 es de tipo desconocido.");
}

// dato2
if (dato2 is int)
{
    Console.WriteLine("La variable object dato2 es de tipo entero.");
}
else if (dato2 is string)
{
    Console.WriteLine("La variable object dato2 es de tipo string.");
}
else if (dato2 is double)
{
    Console.WriteLine("La variable object dato2 es de tipo double.");
}
else
{
    Console.WriteLine("La variable object dato2 es de tipo desconocido.");
}

// dato3
if (dato3 is int)
{
    Console.WriteLine("La variable object dato3 es de tipo entero.");
}
else if (dato3 is string)
{
    Console.WriteLine("La variable object dato3 es de tipo string.");
}
else if (dato3 is double)
{
    Console.WriteLine("La variable object dato3 es de tipo double.");
}
else
{
    Console.WriteLine("La variable object dato3 es de tipo desconocido.");
}



// NIVEL 7 - FOR

// Ejercicio 20 - Del 1 al 10
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{i}");
}


// Ejercicio 21 - Números pares
for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine($"{i}");
}


// Ejercicio 22 - Cuenta atrás
for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}


// Ejercicio 23 - Tabla de multiplicar
Console.WriteLine("Introduce qué tabla de multiplicar quieres ver: ");
int tablaMulti = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{tablaMulti} x {i} = {tablaMulti*i}");
}


// Ejercicio 24 - Suma acumulada
int contador = 0;

for (int i = 1; i <= 100; i++ )
{

    Console.WriteLine($"{contador}");
    contador += i;
}
Console.WriteLine($"{contador}");



// NIVEL 8 - WHILE

// Ejercicio 25 - Contador
int cont = 1;
while (cont <= 10)
{
    Console.WriteLine($"{cont}");
    cont++;
}


// Ejercicio 26 - Cuenta atrás
int counterStrike = 10;

while (counterStrike >= 1 )
{
    Console.WriteLine($"{counterStrike}");
    counterStrike --;
}


// Ejercicio 27 - Seguir hasta cero
int numIntro = -1;
while (numIntro != 0){
    Console.WriteLine("Introduce un número.");
    numIntro = int.Parse(Console.ReadLine() ?? "");
}

Console.WriteLine("Programa terminado.");


// Ejercicio 28 - Acumlar números
int numUser = -1;
int sumaTotal = 0;

while (numUser != 0)
{
    Console.WriteLine("Introduce un número: ");
    numUser = int.Parse(Console.ReadLine() ?? "");

    sumaTotal = numUser + sumaTotal;
}

Console.WriteLine($"La suma total de los valores introducidos es {sumaTotal}\nSaliendo del programa...");



// NIVEL 9 - DO WHILE

// Ejercicio 29 - Pedir contraseña
string contrasena2 = "";
string contrasenaCorrecta2 = "abc123";

do
{
    Console.WriteLine("Introduce la contraseña: ");
    contrasena2 = Console.ReadLine() ?? "";
    Console.WriteLine("Contraseña incorrecta.");
}while(contrasena2 != contrasenaCorrecta2);

Console.WriteLine("Contraseña correcta.");


// Ejercicio 30 - Menú repetitivo
int userOption = 0;

do
{
    Console.WriteLine("Selecciona una opción de la lista: ");
    Console.WriteLine("1. Saludar\n2. Mostrar fecha\n3. Salir\n");
    userOption = int.Parse(Console.ReadLine() ?? "");
} while (userOption != 3);



// NIVEL 10 - ARRAYS

// Ejercicio 31 - Crear un array
int[] numArray = {1, 2, 3, 4, 5};

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(numArray[i]);
}


// Ejercicio 32 - Nombres
string[] nombres = { "Ana", "Luis", "Carlos", "Marta" };

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}


// Ejercicio 33 - Modificar un elemento
int[] numeros = {10, 20, 30, 40, 50};
numeros[1] = 100;

int contArray = 0;

while(contArray < numeros.Length)
{
    Console.WriteLine(numeros[contArray]);
    contArray++;
}


// Ejercicio 34 - Mayor y menor
int[] listaNumeros = {26, 14, 93, 99, 1};


int numeroMenor = listaNumeros[0]; // Inicio las variables con el valor del primer valor del array, sobre todo para que el número menor se compare con algo
int numeroMayor = listaNumeros[0]; // Si alguna no se inicia con la posición del array da este error del compilador: CS9174

for (int i = 0; i < listaNumeros.Length; i++)
{
    // Comprobar para sacar el mayor
    if (listaNumeros[i] > numeroMayor)
    {
        numeroMayor = listaNumeros[i];
    }

    // Sacar el menor
    if (listaNumeros[i] < numeroMenor)
    {
        numeroMenor = listaNumeros[i];
    }
}

Console.WriteLine("El número mayor es: " + numeroMayor);
Console.WriteLine("El número menor es: " + numeroMenor);


// Ejercicio 35 - Suma y media
decimal[] listaNotas = {4.5m, 5m, 7m, 8.25m, 10m, 1.25m, 6m};

decimal sumaNotas = 0m;
decimal mediaNotas = 0m;

foreach (decimal notaA in listaNotas)
{
    sumaNotas += notaA;
    mediaNotas = (sumaNotas / listaNotas.Length);
    Console.WriteLine($"Las notas obtenidas son {notaA}");

}

Console.WriteLine($"La suma de todas las notas es: {sumaNotas}");

Console.WriteLine($"La media de las notas es: {mediaNotas}");



// NIVEL 11 - ARRAYS + CONDICIONES

// Ejercicio 36 - Aprobados
decimal[] notasFinales = {4.75m, 6m, 7.5m, 8m, 9m, 2m, 5.75m};

foreach (decimal notaB in notasFinales)
{
    if (notaB >= 5)
    {
        Console.WriteLine($"{notaB} - Aprobado");
    }
    else
    {
        Console.WriteLine($"{notaB} - Suspenso");
    }
}


// Ejercicio 37 - Contar aprobados y bonus track los suspensos también
int[] notas2 = {4, 7, 8, 3, 5, 9};
int alumnosAprobados = 0;
int alumnosSuspensos = 0;

foreach (int notaC in notas2)
{
    if (notaC >= 5)
    {
        alumnosAprobados++;
    }
    else
    {
        alumnosSuspensos++;
    }
}

Console.WriteLine($"Aprobados: {alumnosAprobados}");
Console.WriteLine($"Suspensos: {alumnosSuspensos}");


// Ejercicio 38 - Números pares
int[] numerosEnteros = {1, 2, 5, 7, 6, 10, 22, 29, 30};

for (int i = 0; i<numerosEnteros.Length; i++)
{
    if (numerosEnteros[i] % 2 == 0)
    {
        Console.WriteLine($"Número par: {numerosEnteros[i]}");
    }
}



// NIVEL 12 - ENUMERACIONES

// Ejercicio 39 - Crear un enum
Color colorElegido = Color.Azul;
Console.WriteLine($"El color elegido es {colorElegido}");


// Ejercicio 40 - enum + switch
Nivel nivelElegido = Nivel.Bajo;
  
switch (nivelElegido)
{
    case Nivel.Bajo:
        Console.WriteLine("Has elegido el nivel BAJO");
        break;
    case Nivel.Medio:
        Console.WriteLine("Has elegido el nivel MEDIO");
        break;
    case Nivel.Alto:
        Console.WriteLine("Has elegido el nivel ALTO");
        break;
    default:
        Console.WriteLine("Nivel desconocido");
        break;
}


// Ejercicio 41 - enum + switch expression
Nivel nivelElegido2 = Nivel.Alto; // En una variable guardamos valor del enum en el archivo nivel40.cs

string mensajeNivel = nivelElegido2 switch // Se hace un switch expression creando una variable con el mensaje

{
    Nivel.Bajo => "Nivel bajo",
     Nivel.Medio => "Nivel medio",
     Nivel.Alto => "Nivel alto",
     _ => "Desconocido ¿?"
};

Console.WriteLine(mensajeNivel);



// NIVEL 13 - RETOS

// Ejercicio 42 - Analizador de notas
int numNotas = 0;

Console.WriteLine("¿Cuántas notas vas a introducir?: ");
numNotas = int.Parse(Console.ReadLine() ?? "");

decimal[] arrayNotas = new decimal[numNotas];

for (int i = 0; i < arrayNotas.Length; i++)
{
    Console.WriteLine("Introduce una nota: ");
    arrayNotas[i] = decimal.Parse(Console.ReadLine() ?? "");
}

decimal sumaArray = 0m;
decimal notaMayorArr = 0m;
decimal notaMenorArr = 11m;
int numAprobados = 0;
int numSuspensos = 0;

for (int i = 0; i < arrayNotas.Length; i++)
{
    sumaArray += arrayNotas[i];

    if (arrayNotas[i] > notaMayorArr)
    {
        notaMayorArr = arrayNotas[i];
    }

    if (arrayNotas[i] < notaMenorArr)
    {
        notaMenorArr = arrayNotas[i];
    }

    if (arrayNotas[i] >= 5m)
    {
        numAprobados++;
    }
    else
    {
        numSuspensos++;
    }
}

Console.WriteLine($"La media de las notas es {sumaArray/arrayNotas.Length}");
Console.WriteLine($"La nota más alta es {notaMayorArr}");
Console.WriteLine($"La nota más baja es {notaMenorArr}");
Console.WriteLine($"En total ha habido {numAprobados} aprobados y {numSuspensos} suspensos.");


// Ejercicio 43 - Adivinar el número
int secretNumber = 7;
int numeroUser = 0;

Console.WriteLine ("Adivina el número secreto: \n Por cada intento si fallas y el número es menor o mayor se mostrará un mensaje.\n Si lo aciertas será igual y se acabará el juego");


while (numeroUser != secretNumber)
{
    Console.Write("Introduce el número: ");
    numUser = int.Parse(Console.ReadLine() ?? "");

    if (numeroUser < secretNumber)
    {
        Console.Write($"{numeroUser} es menor al número secreto\n");
        
    }
    else if (numeroUser > secretNumber)
    {
        Console.Write($"{numeroUser} es mayor que el número secreto\n");
        
    }
    else
    {
        Console.Write($"¡¡ HAS ACERTADO EL NÚMERO SECRETO QUE ERA {secretNumber}\n");
    }
}


// Ejercicio 44 - Menú completo 
int opcionMenu = 0;
int numIntroducido = 0;

do
{
    Console.WriteLine("¿Qué quieres hacer (1. Introducir número | 2. Mostrar número | 3. Comprobar si es par | 4. Mostrar doble | 5. Salir)?: ");
    opcionMenu = int.Parse(Console.ReadLine() ?? "");

    switch (opcionMenu)
    {
        case 1:
            Console.WriteLine("Introduce un número: ");
            numIntroducido = int.Parse(Console.ReadLine() ?? "");
            break;

        case 2:
            Console.WriteLine($"El número que has introducido es {numIntroducido}");
            break;

        case 3:
            if(numIntroducido % 2 == 0)
            {
                Console.WriteLine($"El número que has introducido es par");
            }
            else
            {
                Console.WriteLine($"El número que has introducido es impar");
            }

            break;

        case 4:
            Console.WriteLine($"El doble del número que has introducido es {numIntroducido*2}");
            break;

        case 5:
            Console.WriteLine("Programa terminado");
            break;

        default:
            Console.WriteLine("Opción desconocida");
            break;
    }
    
}while(opcionMenu != 5);



// NIVEL 14 - RETO FINAL

// Ejercicio 45 - Gestión de notas

double[] notasFinales2 = { 7.5, 4.0, 8.5, 6.0, 3.5, 9.0};

double mediaNotas2 = 0.0;
double notaMayor = notasFinales2[0];
double notaMenor = notasFinales2[0];
int numeroAprobados = 0;
int numeroSuspensos = 0;
bool mediaMayorIgual5 = false;



foreach (double notas in notasFinales2)
{
    Console.WriteLine(notas); // Mostrar todas las notas
    mediaNotas2 += (notas) / notasFinales2.Length;

    if (notas > notaMayor)
    {
        notaMayor = notas;
    }
   
   if (notas < notaMenor)
    {
        notaMenor = notas;
    }

    if (notas >= 5)
    {
        numeroAprobados++;
    }
    else
    {
        numeroSuspensos++;
    }

    if (mediaNotas >= 5)
    {
        mediaMayorIgual5 = true;
    }

   
}

// Mostrar resultados de las operaciones del bucle
Console.WriteLine($"Media de todas las notas {mediaNotas}"); // Mostrar la media de las notas
Console.WriteLine($"Nota mayor: {notaMayor}");
Console.WriteLine($"Nota menor: {notaMenor}");
Console.WriteLine($"Número de aprobados: {numeroAprobados}");
Console.WriteLine($"Número de suspendidos: {numeroSuspensos}");
Console.WriteLine($"Media del grupo mayor o igual a 5: {mediaMayorIgual5}");

// Pedir un numero por teclado al usuario y mostrar el mensaje de la switch expression

Console.WriteLine("Dí un número:");
int opcionMedia = int.Parse(Console.ReadLine() ?? "");


string mensajeMedia = opcionMedia switch // Crear la switch expression
{
    1 => "Media Alta",
    2 => "Media Baja",
    _ => "Desconocido??"
};

Console.Write($"{mensajeMedia} ");



// RETO EXTRA

// Ejercicio 46 - Analizador genérico
object[] datos =
{
    10,
    "Hola",
    5.5m,
    true,
    25
};

foreach (object datoArray in datos) 
{
    if (datoArray is int)
    {
        Console.WriteLine("Este objeto es de tipo ENTERO.");
    }
    else if (datoArray is string)
    {
        Console.WriteLine("Este objeto es de tipo STRING.");
    }
    else if (datoArray is decimal)
    {
        Console.WriteLine("Este objeto es de tipo DECIMAL.");
    }
    else if (datoArray is bool)
    {
        Console.WriteLine("Este objeto es de tipo BOOLEANO.");
    }
    else
    {
        Console.WriteLine("Este objeto es de tipo DESCONOCIDO.");
    }
};