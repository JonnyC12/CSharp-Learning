using interfaces;

var mamifero = new Mamifero("Nombre", "Tipo");
mamifero.Presentandome();
var caballo = new Caballo("Potro", "tipo2", 4);
Console.WriteLine($"Soy un caballo y tengo una interfaz con un metodo numero de patas, así que tengo: {caballo} patas");

// Ejemplo de principio de sustitucion 
Mamifero mamiferoCaballo = caballo;

Console.WriteLine($"Ahora me he convertido por el principio de sustitucion en un tipo mamifero y no tengo mi funcion patas");


//* Ahora aplicaremos el principio de sustitucion para poder acceder a lo metedos que tienen el mismo nombre

IMamiferoConPatas I1 = caballo; // un caballo es un mamifero con patas
IMamiferoTerrestre I2 = caballo; // un caballo es un mamifero terrestre

//* Ahora podemos obsevar que diferenciamos a que interfaz pertenece el método que estamos llamando
I1.Correr();
I1.NumeroDePatas();
I2.NumeroDePatas();