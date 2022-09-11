using absClass;

Lagartija rep = new Lagartija("Juancho");

Mamiferos mam = new Mamiferos("Pedro");

//*Como podemos observar podemos acceder al método de la clase abstracta que ya estaba desarrollado.
rep.Respirar();
mam.Respirar();

//* Usando el método que hemos heredado de la clase abstracta animales y estamos obligados a desarrollar.
rep.GetNombre();
mam.GetNombre();