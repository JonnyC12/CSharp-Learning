using Mistruck;


Empleado p = new Empleado("Juan");

// De esta manera podemos settear de una forma más rápida y con menos sintaxis respetando la encapsulación del método
p.Salario = 1000;
Console.WriteLine($"El salario es {p.Salario}");
// Probamos que la condicion if impuesta en la propierties 
p.Salario = -100;
Console.WriteLine($"El salario cambiado es: {p.Salario}");

p.HorasTrabajo = 10;

Console.WriteLine("Las horas de trabajo son {0}", p.HorasTrabajo);

EmpleadoStruck prueba = new EmpleadoStruck("GHOla", 20);

prueba.ModificarSalario(prueba, 300);
Console.WriteLine(prueba.salario);



enum aumentos { extra = 500 };