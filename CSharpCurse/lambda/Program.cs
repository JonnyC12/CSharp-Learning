
// Ejemplo de expresiones lambda. 



//! instanciamos el objeto delegado para que se enlace con la función que queremos que se ejecute
OperacionesMatematicas obj = new OperacionesMatematicas(num => num * num); // usamos la funcion lambda

// ! Lambda con dos parametros
OperacionesConDosArgs obj2 = new OperacionesConDosArgs((num1, num2) => num1 + num2);
// ! Ejemplo con predicate 

Predicate<int> miPredicado = new Predicate<int>(x => x % 2 == 0);

Console.WriteLine(obj(2));

Console.WriteLine(obj2(1, 2));

//Ejemplo con predicate
List<int> numeros = new List<int>();
numeros.AddRange(new int[] { 1, 2, 3, 4, 6 });

List<int> Pares = numeros.FindAll(miPredicado);
// Podemos simplicarlo más todavia

List<int> ParesForma2 = numeros.FindAll(x => x % 2 == 0);

// ! quitamos la funcion y usamos lambda
// static int Cuadrado(int n)
// {
//     return n ^ n;
// }


delegate int OperacionesMatematicas(int n);
delegate int OperacionesConDosArgs(int n, int m);


class Persona
{
    public string nombre { get; set; }
    public int edad { get; set; }

}
