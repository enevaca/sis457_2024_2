// See https://aka.ms/new-console-template for more information
using DemoBiblioteca;
using DemoConsolaAvanzado;

// Bibiliteca de Clases
int suma = Calculadora.sumar(5, 6);
int resta = Calculadora.restar(9, 6);
int mult = Calculadora.multiplicar(2, 7);
int div = Calculadora.dividir(49, 7);
Console.WriteLine($"Suma: {suma}, Resta: {resta}.");

// Delegados
static string revertirCadena(string cadena)
{
    return new string(cadena.Reverse().ToArray());
}
Revertir revertir = revertirCadena;
Console.WriteLine(revertir("Hola Delegado"));

void imprimir(string cadena)
{
    Console.WriteLine("Delegado Action: " + cadena);
}
Action<string> imp = imprimir;
imp("SIS457");

Func<int, int, int> mulplicar = (n1, n2) => n1 * n2;
int multiplicacion = mulplicar(5, 7);
Console.WriteLine("El resultado de la multiplicación es: " + multiplicacion);

Predicate<int> mayorEdad = edad => edad >= 18;
bool esMayorEdad = mayorEdad(25);
Console.WriteLine("Es mayor de edad: " + esMayorEdad);

// Genéricos
Generico<int, string> generico = new Generico<int, string>();
generico.campo1 = 56;
generico.campo2 = "Hola Genérico";
generico.imprimir(7);

Generico<bool, Automovil> generico2 = new Generico<bool, Automovil>();
generico2.campo1 = true;
generico2.campo2 = new Automovil();
generico2.imprimir(false);

// Interfaces
//IVehiculo vehiculo = new IVehiculo(); // No se puede instanciar
Automovil automovil = new Automovil();
automovil.acelerar(40);
automovil.frenar();
automovil.girar(15);

// Clases Abstractas
//FiguraGeometrica figuraGeometrica = new FiguraGeometrica(); // No se puede instanciar
Cuadrado cuadrado = new Cuadrado(5);
Console.WriteLine($"El área del cuadrado es: {cuadrado.area()}");
Console.WriteLine($"El perímetro del cuadrado es: {cuadrado.perimetro()}");

Rectangulo rectangulo = new Rectangulo(9, 7);
Console.WriteLine($"El área del rectángulo es: {rectangulo.area()}");
Console.WriteLine($"El perímetro del rectángulo es: {rectangulo.perimetro()}");

// Manejo de Excepciones (try/catch/finally)
int a, b, division;
try
{
    Console.Write("Introduzca número 1: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduzca número 2: ");
    b = Convert.ToInt32(Console.ReadLine());

    division = a / b;
    Console.WriteLine($"El resultado es {division}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("No es posible la división por Cero. " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Excepción no controlada. " + ex.Message);
}
finally
{
    division = 0;
    Console.WriteLine("Finalizado");
}


// Programación Asíncrona (async/await)
testAsyncAwaitMethod();
Console.WriteLine("Presiona cualquier tecla para salir");
Console.ReadLine();

static async void testAsyncAwaitMethod()
{
    await longRunningMethod();
}

static async Task<int> longRunningMethod()
{
    Console.WriteLine("Iniciando un método de larga duración");
    await Task.Delay(5000);
    Console.WriteLine("Fin del método de larga duración");
    return 0;
}

// Inmutabilidad
Inmutable inmutable = new Inmutable(22);
// inmutable.year = 23; No se puede asignar un valor a un atributo readonly
