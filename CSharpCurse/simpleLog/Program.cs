
using simpleLog;


LogClass log = new LogClass($".{Path.DirectorySeparatorChar}log.txt");

Console.WriteLine($"Introduzca una fecha en formato año/mes/dia");

string? DateString = Console.ReadLine();

log.Write(DateString);

Console.WriteLine(log.Read());