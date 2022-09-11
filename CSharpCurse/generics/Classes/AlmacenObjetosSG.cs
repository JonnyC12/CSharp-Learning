class AlmacenObjetosSG
{
    private Object[] datosElementos;
    private int i = 0;
    public AlmacenObjetosSG(int z)
    {
        datosElementos = new object[z];
    }

    public void SetElemento(Object obj)
    {
        datosElementos[i] = obj;
        i++;
    }
    public Object GetElemento(int index)
    {
        return datosElementos[index];
    }

}