
// Variables
var variable = "Cualquier valor";
bool esActivo = false;
int entero = 4;
long enteroLargo = 121212121212;
double real = 46.45;
decimal real2 = 17.56M;
float real3 = 78.56F;
char caracter = 'A';
string cadena = "Esto es una cadena";
Int32 entero2 = 56;
Int64 enteroLargo2 = 566446545666;
DateTime fecha = DateTime.Now;

// Constantes
const double PI = 3.1416;
const string SIGLA_MATERIA = "SIS457";

// Operadores y expresiones
entero = 10;
entero2 += 5;
entero2 %= 2;
bool esPar = entero2 % 2 == 0;
int a = 5 + 4 * 2;
int b = (5 - 3) * 2;

// Conversiones y cadenas
string conversionCadena = Convert.ToString(real);
int conversionEntero = Convert.ToInt32("457");
bool conversionBool = Convert.ToBoolean("true");

string materia = "Fundamentos de la Programación";
string concatenar = materia + " - " + SIGLA_MATERIA;
string concatenar2 = $"{materia} - {SIGLA_MATERIA}";
string[] separar = concatenar.Split(" ");
string invertir = new string(concatenar.Reverse().ToArray());
string mayuscula = concatenar.ToUpper();
string minuscula = concatenar.ToLower();
string sinEspaciosExtremos = " HOLA QUE TAL ".Trim();
string reemplazo = concatenar.Replace(" ", "_");
string subcadena = concatenar.Substring(0, 5);
int longitudCadena = concatenar.Length;
string anidarFunciones = materia.ToUpper().Replace(" ", "").Trim();

// Estructuras de Control
bool esMayorCero;
if (cadena.Length > 0) esMayorCero = true;
else esMayorCero = false;
bool esMayorCero2 = cadena.Length > 0 ? true : false;
bool esMayorCero3 = cadena.Length > 0;

switch (materia)
{
    case "Informatica": materia += "Info"; break;
    default: materia = materia.ToUpper(); break;
}

int contador = 0;
while (contador < 3)
{
    Console.WriteLine($"Contador while: {contador}.");
    contador++;
}

do
{
    Console.WriteLine($"Contador do while: {contador}.");
    contador--;
} while (contador > 0);

for (int i = 0; i < separar.Length; i++)
{
    Console.WriteLine($"Ciclo for -> Posición {i}: {separar[i]}");
}

foreach (string s in separar) Console.WriteLine($"foreach: {s}");

// Métodos
void saludo(string nombre)
{
    Console.WriteLine($"Hola qué tal {nombre}?");
}
saludo("Juan");

string revertirCadena(string cadena)
{
    return new string(cadena.Reverse().ToArray());
}
Console.WriteLine(revertirCadena("HOLA MUNDO"));

int suma(int numero1, int numero2) => numero1 + numero2;

Console.WriteLine(suma(7, 6));

// Factorial
Console.Write("Introduzca un número: ");
int numero = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
if (Math.Abs(numero) > 1)
{
    for (int i = 1; i <= Math.Abs(numero); i++) factorial *= i;
    if (numero < 0) factorial *= -1;
}
Console.WriteLine($"El factorial de {numero} es: {factorial}");
// Número Primo (Tarea)


// POO -> próximamente
