using System.IO;
class Util

{
    StreamReader archivo = null;
    private int contador = 0;
    private string linea;
    public Util()
    {
        archivo = new StreamReader("./texto.txt");

        while ((linea = archivo.ReadLine()) != null)


        {
            Console.WriteLine(linea);

            contador++;
        }
    }
    public void msg()
    {
        Console.WriteLine($"hay {contador} lineas");
    }
    // Liberacion explicita
    public void Dispose()
    {
        throw new NotImplementedException();
    }
    //Liberacion implicita sin tener que llamaarla lo hara el garbage collection
    ~Util()
    {
        archivo.Close();
    }
}