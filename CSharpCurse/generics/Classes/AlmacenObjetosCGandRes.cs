class AlmacenObjetosCGandRes<T> where T : IParaEmpleados // con las palabras reservadas where t : i, especificamos que solo permitimos objetos con esas iinterfaces 
{
    private T[] datosElementos; // así declaramos un array con generic
    private int i = 0;
    public AlmacenObjetosCGandRes(int z)
    {
        datosElementos = new T[z]; // inicializamos el array generic
    }

    public void SetElemento(T obj) // así se establece un parametro generic
    {
        datosElementos[i] = obj;
        i++;
    }
    public T GetElemento(int index) // así se establece que la función va a devolver un clase Generic, es decir, cualquier tipo de clase
    {
        return datosElementos[index];
    }


}