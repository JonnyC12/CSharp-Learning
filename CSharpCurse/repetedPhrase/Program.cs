String STOPKEY = "NetMentor";
String nombre = "";

do
{
    Console.WriteLine($"Escriba el nombre que quiere que se repita");
    nombre = Console.ReadLine();
    Console.WriteLine($"El nombre introducido es: {nombre}");
    Console.WriteLine($"Introduzca el nombre correcto para salir de bucle");

} while (!STOPKEY.Equals(nombre));
Console.WriteLine($"El nombre introducido ha sido el correcto, bucle terminado!");


