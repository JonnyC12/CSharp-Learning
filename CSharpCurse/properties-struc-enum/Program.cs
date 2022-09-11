using Mistruck;


Empleado p = new Empleado("Juan");

// De esta manera podemos settear de una forma más rápida y con menos sintaxis respetando la encapsulación del método
p.Salario = -100;
Console.WriteLine($"El salario es {p.Salario}");
// Probamos que la condicion if impuesta en la propierties 
p.Salario = 1000;
Console.WriteLine($"El salario cambiado es: {p.Salario}");

p.HorasTrabajo = 10;

Console.WriteLine("Las horas de trabajo son {0}", p.HorasTrabajo);
// Prueba del funcionamiento de estruck, struck se almacena en pila por lo que hace copias del mismo cuando isntanaciamos un objeto struct, por lo que si pasamos el propio obj por parametro no modificara el mismo
EmpleadoStruck prueba = new EmpleadoStruck("GHOla", 20);

prueba.ModificarSalario(prueba, 300);

//! Como podemos observar el salario no se ha visto afectado, si fuera un clase si serí afectado ya que una clase se referencia. 
Console.WriteLine(prueba.salario);


// instanciamos el aumento que le queremos hacer a la persona p 
aumentos doble = aumentos.doble;

p.AplicarExtra(doble);

Console.WriteLine("aplicando el extra el salario ha aumentado a {0}", p.Salario);
