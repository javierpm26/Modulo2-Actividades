//NIVEL 1 - MOSTRAR INFORMACIÓN

//Ejercicio 1 - Presentación
string nombre = "Beatriz";
const string CIUDAD = "Socuéllamos";
int edad = 27;
string comidaFavorita = "macarrones";

Console.WriteLine($"Hola, me llamo {nombre}, y vivo en {CIUDAD}. \nTengo {edad} años, y mi comida favorita es un plato de {comidaFavorita}. ");


//Ejercicio 2 - Datos básicos
string nombre2 = "Javier";
int edad2 = 25;
double altura = 1.72;
bool estudiante = true;

Console.WriteLine($"Hola me llamo {nombre2}, y tengo {edad2} años. Mido {altura} metros");

Console.WriteLine($"¿Soy estudiante?{estudiante}");


//NIVEL 2 - PEDIR DATOS

//Ejercicio 3 - Saludo
string nombre3 = "";
string ciudad2 = "";

Console.WriteLine("Introduce tu nombre:");
nombre3 = Console.ReadLine() ?? "";

Console.WriteLine("Introduce tu ciudad:");
ciudad2 = Console.ReadLine() ?? "";

Console.WriteLine($"Hola, {nombre3}. Tu ciudad, {ciudad2}, es muy bonita.");


//Ejercicio 4 - Edad
int edad3 = 0;
Console.WriteLine("Dime tu edad");
edad3 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"Ok, tu edad es {edad3}");

//Ejercicio 5 - Producto
string nombreProd = "";
double precioProd = 0.0;

Console.WriteLine("Introduce el nombre del producto: ");
nombreProd = Console.ReadLine() ?? "";
Console.WriteLine("Introduce el precio del producto: ");
precioProd = double.Parse(Console.ReadLine() ?? "");
//Hay que meter siempre el número en consola cuando lo pida o dará error al quedar como null e intentar convertir el string a double
//Para introducir decimales por consola, utilizar ,

Console.WriteLine($"El producto introducido es {nombreProd} con un valor de {precioProd} euros.");


// NIVEL 3 - OPERACIONES SENCILLAS

// Ejercicio 6 - Suma de dos números
int numA =  0;
int numB = 0;

Console.WriteLine("Numero entero A: ");
numA = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Numero entero B: ");
numB = int.Parse(Console.ReadLine() ?? "");

// Sumar
int suma = numA + numB;
Console.WriteLine($"El resultado de la suma es: {suma}.");

// Resta
int resta = numA - numB;
Console.WriteLine($"El resultado de la resta es: {resta}");

// Multiplicación
int multiplicacion = numA * numB;
Console.WriteLine($"El resultado de la multiplicación es {multiplicacion}");

//Ejercicio 7 - División y resto
//División
Console.WriteLine("Introduce un número: ");
int numC = int.Parse(Console.ReadLine() ?? "");

//Resto
Console.WriteLine("Introduce otro número: ");
int numD = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"El resultado de la división entre {numC} y {numD} es {numC / numD}.");
Console.WriteLine($"El resto de la división entre {numC} y {numD} es {numC % numD}.");


// Ejercicio 8 - Conversión de minutos
int minutos = 0;

Console.WriteLine("Minutos a convertir a horas");
minutos = int.Parse(Console.ReadLine() ?? "");

int horas = minutos / 60;
Console.WriteLine($"{minutos} minutos son {horas} horas");

int minRestantes = minutos % 60;
Console.WriteLine($"Minutos restantes {minRestantes}");


//NIVEL 4 - OPERACIONES CON DECIMALES

// Ejercicio 9 - Área de un rectángulo
double baseR = 0.0;
double alturaR = 0.0;

Console.WriteLine("Introduce la base de tu rectángulo: ");
baseR = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Introduce la altura de tu rectángulo: ");
alturaR = double.Parse(Console.ReadLine() ?? "");

//área = base * altura
Console.WriteLine($"El área de tu rectángulo es {baseR * alturaR}.");


// Ejercicio 10 - Precio Final
decimal productA = 0;
decimal productB = 0;

Console.WriteLine("Producto A: ");
productA = decimal.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Producto B: ");
productB = decimal.Parse(Console.ReadLine() ?? "");

decimal precioTotal = productA + productB;
Console.WriteLine($"El precio total de los productos {productA} y {productB} es {precioTotal}");

decimal precioMedio = precioTotal / 2;
Console.WriteLine($"El precio medio de {productA} y {productB} es {precioMedio}");

// Ejercicio 11 - Conversión de temperatura
double tempCelsius = 0.0;

Console.WriteLine("Introduce la temperatura en grados Celsius: ");
tempCelsius = double.Parse(Console.ReadLine() ?? "");

//F = C * 9 / 5 + 32

Console.WriteLine($"La temperatura introducida en grados Fahrenheit es de {tempCelsius * 9 / 5 + 32} grados.");


// NIVEL 5 - COMPARACIONES

// Ejercicio 12 - Mayor o menor
int numero1 = 0;
int numero2 = 0;

Console.WriteLine("Introduce el primer número entero: ");
numero1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ahora introduce el segundo número entero: ");
numero2 = int.Parse(Console.ReadLine() ?? "");

bool primeroMayor = numero1 > numero2;
Console.WriteLine($"{primeroMayor}");

bool primeroMenor = numero1 < numero2;
Console.WriteLine($"{primeroMenor}");

bool sonIguales = numero1 == numero2;
Console.WriteLine($"{sonIguales}");

bool sonDiferentes = numero1 != numero2;
Console.WriteLine($"{sonDiferentes}");


// Ejercicio 13 - Nota de un alumno
decimal notaAlum = 0;
bool mayorIgual5 = false;
bool menor5 = false;
bool igual10 = false;

Console.WriteLine("Introduce la nota del alumno: ");
notaAlum = decimal.Parse(Console.ReadLine() ?? "");

mayorIgual5 = notaAlum >= 5;
Console.WriteLine($"¿Es la nota del alumno mayor o igual que 5? {mayorIgual5}");

menor5 = notaAlum < 5;
Console.WriteLine($"¿Es la nota del alumno menor que 5? {menor5}");

igual10 = notaAlum == 10;
Console.WriteLine($"¿Es la nota del alumno igual a 10? {igual10}");


// NIVEL 6 - OPERADORES LÓGICOS

// Ejercicio 14 - Comprobar condiciones
int edad4 = 0;

int entradasDisponibles = 0;

// edad
Console.WriteLine("14. Edad: ");
edad4 = int.Parse(Console.ReadLine() ?? "");

// entradas disponibles
Console.WriteLine("14. Entradas disponibles: ");

entradasDisponibles = int.Parse(Console.ReadLine() ?? "");


// la persona es mayor de edad
bool mayorEdad = edad4 >= 18;

Console.WriteLine($"¿Es mayor de edad?: {mayorEdad}");


// hay al menos una entrada disponible
bool hayEntradas = entradasDisponibles >= 1;

Console.WriteLine($"¿Hay entradas disponibles?: {hayEntradas}");


// Primera condición: AND (&&)
bool primeraCondicion = edad4 >= 18 && entradasDisponibles >= 1;

Console.WriteLine($"¿Es mayor de edad Y hay entradas?: {primeraCondicion}");


// Segunda condición: OR (||)
bool segundaCondicion = edad4 >= 18 || entradasDisponibles >= 1;

Console.WriteLine($"¿Es mayor de edad O hay entradas?: {segundaCondicion}");


// Ejercicio 15 - Cuenta bancaria
double saldoDisp = 0;
double precioProd2 = 0;

bool saldoSufi = false;
bool saldoInsufi = false;
bool saldoPrecio = false;

Console.WriteLine("Introduce el saldo disponible: ");
saldoDisp = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Introduce el precio del producto a comprar: ");
precioProd2 = double.Parse(Console.ReadLine() ?? "");

saldoSufi = saldoDisp >= precioProd2;
Console.WriteLine($"¿Es el saldo suficiente para comprar el producto? {saldoSufi}");

saldoInsufi = saldoDisp < precioProd2;
Console.WriteLine($"¿Es el saldo insuficiente para comprar el producto? {saldoInsufi}");

saldoPrecio = saldoSufi && precioProd2 > 0;
Console.WriteLine($"¿Es el saldo suficiente y el precio mayor que 0? {saldoPrecio}");


// NIVEL 7 - MEDIAS Y CONVERSIONES

//Ejercicio 16 - Media de 3 notas
decimal nota1 = 0;
decimal nota2 = 0;
decimal nota3 = 0;

Console.WriteLine("Nota 1: ");
nota1 = decimal.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Nota 2: ");
nota2 = decimal.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Nota 3: ");
nota3 = decimal.Parse(Console.ReadLine() ?? "");

//Mostrar las tres notas
Console.WriteLine($"Las tres notas introducidas son {nota1}, {nota2}, {nota3}");

//La suma
decimal sumaNotas = nota1 + nota2 + nota3;
Console.WriteLine($"La suma de las tres notas es {sumaNotas}");

//La media
decimal mediaNotas = sumaNotas / 3;
Console.WriteLine($"La media de las tres notas es {mediaNotas}");

//¿La media es mayor o igual a 5
bool mayorIgual = mediaNotas >= 5;
Console.WriteLine($"¿La media de las notas es mayor o igual a 5?: {mayorIgual} ");


// Ejercicio 17 - Media de cuatro números
int numEnt1 = 0;
int numEnt2 = 0;
int numEnt3 = 0;
int numEnt4 = 0;

Console.WriteLine("Introduce el primer número: ");
numEnt1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Introduce el segundo número: ");
numEnt2 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Introduce el tercer número: ");
numEnt3 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Introduce el cuarto número: ");
numEnt4 = int.Parse(Console.ReadLine() ?? "");


// La suma de los cuatro números
int sumaTotal = numEnt1 + numEnt2 + numEnt3 + numEnt4;
Console.WriteLine($"La suma de los cuatro números es {sumaTotal}");

// La media de los cuatro números
decimal mediaNum = (decimal)sumaTotal / 4;
Console.WriteLine($"La media de los cuatro números es {mediaNum}");

// El resto de la media de los cuatro números
int restoMedia = sumaTotal % 4;
Console.WriteLine($"El resto de la media es: {restoMedia}");


// NIVEL 8 - RETOS

// Ejercicio 18 - Descomponer una cantidad
int cantidadInicial = 0;
int billetes50 = 0;
int billetes20 = 0;
int billetes10 = 0;
int restoDinero = 0;
int eurosSobrantes = 0;

Console.WriteLine("Cantidad de dinero inicial: ");
cantidadInicial = int.Parse(Console.ReadLine() ?? "");

// Con billetes de 50€
billetes50 = cantidadInicial / 50;
Console.WriteLine($"50€: {billetes50} billetes");
restoDinero = cantidadInicial - (50 * billetes50);
Console.WriteLine($"Me han sobrado {restoDinero} euros al repartir.");

// Con billetes de 20€
billetes20 = restoDinero / 20;
Console.WriteLine($"20€: {billetes20} billetes");
restoDinero = restoDinero - (20 * billetes20);
Console.WriteLine($"Me han sobrado {restoDinero} euros al repartir.");

// Con billetes de 10
billetes10 = restoDinero / 10;
Console.WriteLine($"10€: {billetes10} billetes");

// Euros sobrantes
eurosSobrantes = cantidadInicial - (billetes50 * 50 + billetes20 * 20 + billetes10 * 10);
Console.WriteLine($"Euros sobrantes: {eurosSobrantes}");


// Ejercicio 19 - Conversión y operaciones
decimal precioSinIVA = 0;
double porcentajeIVA = 0.0;

// Le pedimos al usuario el precio sin el IVA
Console.WriteLine("Introduce un precio sin IVA: ");
precioSinIVA = decimal.Parse(Console.ReadLine() ?? "");

// Ahora se le pide al usuario que introduzca el porcentaje de IVA que quiere aplicarle
Console.WriteLine("Introduce porcentaje de IVA a aplicar: ");
porcentajeIVA = double.Parse(Console.ReadLine() ?? "");

// Paso a decimal el porcentaje por que no se puede hacer una operación de * con un double y un decimal

decimal cantidadIVA = precioSinIVA * ((decimal)porcentajeIVA / 100);

// Ahora ya por fin se puede calcular el precio total

decimal precioTotal2 = precioSinIVA + cantidadIVA;

Console.WriteLine($"El precio original es: {precioSinIVA}");

Console.WriteLine($"El IVA es: {porcentajeIVA}");

Console.WriteLine($"El precio final es: {precioTotal2}");


// Ejercicio 20 - Analizador de tres números
int primerNumero = 0; 
int segundoNumero = 0;
int tercerNumero = 0;

Console.WriteLine("Primer número: ");
primerNumero = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Segundo número: ");
segundoNumero = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Tercer número: ");
tercerNumero = int.Parse(Console.ReadLine() ?? "");

// La suma de los tres números
Console.WriteLine($"Suma: {primerNumero + segundoNumero + tercerNumero}");

// La media de los tres números
Console.WriteLine($"Media: {(decimal)(primerNumero + segundoNumero + tercerNumero) / 3}");

// Primero mayor que segundo (True or false)
Console.WriteLine($"¿Es {primerNumero} mayor que {segundoNumero}?: {primerNumero > segundoNumero}");

// Segundo mayor que tercero (True or false)
Console.WriteLine($"¿Es {segundoNumero} mayor que {tercerNumero}?: {segundoNumero > tercerNumero}");

// Los tres números son iguales
Console.WriteLine($"¿Los tres números son iguales?: {primerNumero == segundoNumero && primerNumero == tercerNumero}");

// Los tres números son diferentes (operador lógico and &)
Console.WriteLine($"¿Los tres números son diferentes?: {primerNumero != segundoNumero && segundoNumero != tercerNumero && primerNumero != tercerNumero}");

// ¿Están en orden descendente?
Console.WriteLine($"¿Los números están en orden descendente?: {primerNumero > segundoNumero && segundoNumero > tercerNumero}");

// Resto de la suma entre 3
Console.WriteLine($"Resto de la suma entre 3: {(primerNumero + segundoNumero + tercerNumero) % 3}");























