// See https://aka.ms/new-console-template for more information
using DemoConsolaAvanzado;

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
