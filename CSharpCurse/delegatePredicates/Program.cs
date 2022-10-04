
List<int> listaNum = new List<int>();
listaNum.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

// declaramos delegado predicado

Predicate<int> miPredicado = new Predicate<int>(esPar);

var numPares = listaNum.FindAll(miPredicado);

var numPares2 = listaNum.FindAll(x => x % 2 == 0);

Console.WriteLine("Filtro hecho con Obj predicate");
foreach (var item in numPares)
{
    Console.WriteLine(item);
}
Console.WriteLine("Filtro hecho con función lambda");
foreach (var item in numPares2)
{
    Console.WriteLine(item);
}

Console.WriteLine("numeros primos de la lista");
miPredicado = new Predicate<int>(esPrimo);

var primos = listaNum.FindAll(miPredicado);
foreach (var num in primos)
{
    Console.WriteLine(num);
}
static bool esPar(int n)
{
    return n % 2 == 0;
}
// función que vuelve true si un numero es primo. 
static bool esPrimo(int n)
{
    if (n < 1) return false;
    else if (n == 2) return true;
    else
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
