
Persona p1 = new Persona("asidhfiojasdofiajsdfj");
AlmacenObjetosSG almacen = new AlmacenObjetosSG(3);
// guardamos un objeto persona en un objeto que guarda todo tipo de objetos por herencia
almacen.SetElemento(p1);

var obj = almacen.GetElemento(0);

Persona p2 = (Persona)obj;


AlmacenObjetosCG<Persona> Generic = new AlmacenObjetosCG<Persona>(3);

Persona persona = new Persona("Soy Raquel");

Generic.SetElemento(persona);

var personaDevuelta = Generic.GetElemento(0);

Console.WriteLine("el nombre de la persona devuelta es {0}", personaDevuelta.Nombre);

/////////////////////////////////////////////////////////////////////////


// AlmacenObjetosCGandRes<Profesor> empleados = new AlmacenObjetosCGandRes<Profesor>(3);

// empleados.SetElemento(new Profesor(2000));

//! Si observamos bien no nos permite meter objetos que no tenga la interfaz IParaEmpleados enlazada

AlmacenObjetosCGandRes<Director> empleados = new AlmacenObjetosCGandRes<Director>(3);

empleados.SetElemento(new Director(2000));

// * Si observamos ahora que hemos usado una clase que tiene la interfaz implementada si nos permite crear y meter objeetos. 
