using System.Diagnostics;

// Algoritmo que se va a ejecutar en el CPU
async Task<String> Algoritmo(int tipo)
{
    string algoritmo = "";
    if (tipo == 1)
    {
        await Task.Delay(300);
        algoritmo = "Fibonancci";
    }
    if (tipo == 2)
    {
        await Task.Delay(5000);
        algoritmo = "Dofenstmirt";
    }
    if (tipo == 3)
    {
        await Task.Delay(2000);
        algoritmo = "Prim";
    }
    return algoritmo;
}
// Calculo que se va a ejecutar el CPU
async Task<int> Calculo1()
{
    await Task.Delay(2000);
    return 23;
}

async Task<string> EjecucionSinAsyn()
{
    Console.WriteLine($"Ejecutando sin Async");
    Stopwatch timer = new Stopwatch();
    timer.Start();
    await Algoritmo(2);
    await Calculo1();
    timer.Stop();
    TimeSpan ts = timer.Elapsed;
    Console.WriteLine($"El tiempo que ha tardado sin Async: {ts.TotalMilliseconds} ");
    return "Termine sin Asyn";
}

// simulación de ejecución con Async 
async Task<string> EjecucionConAsyn()
{
    Console.WriteLine($"Ejecutando con Async");
    Stopwatch timer = new Stopwatch();
    timer.Start();
    await Task.WhenAll(Algoritmo(1), Calculo1());
    timer.Stop();
    TimeSpan ts = timer.Elapsed;
    Console.WriteLine($"El tiempo que ha tardado con Async: {ts.TotalMilliseconds}");
    return "Termine con Async";
}


await Task.WhenAll(EjecucionConAsyn(), EjecucionSinAsyn());



