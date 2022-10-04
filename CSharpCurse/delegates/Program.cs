
// Hacemos que el objeto delegado apunte al metodo saludo bienvenida 
ObjetoDelegado miDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

// ejecutamos la función saludo bienvenida
miDelegado("Hola mundo este es mi mensaje de bienvenida");

miDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

miDelegado("Hola mundo este es mi mensjae de despedida");

//! definimos el objeto delegado, recuerda que debe coincidir con la estructura de los metodos que vas a delegar. 
delegate void ObjetoDelegado(string msj); //! En este caso como saludo tiene un parametro string msj, en el objeto delegado también pasaremos un parametro por string. 

class MensajeBienvenida
{
    public static void SaludoBienvenida(string msj)
    {
        Console.WriteLine("Mensaje de bienvenida {0}", msj);
    }
}
class MensajeDespedida
{
    public static void SaludoDespedida(string msj)
    {
        Console.WriteLine("Mensaje de despedida {0}", msj);
    }
}





