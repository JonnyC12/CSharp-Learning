class Persona
{
    private string nombre;
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }
    public Persona(string nombre)
    {

        this.nombre = nombre;
    }


}

class Director : IParaEmpleados
{
    private double sueldo;

    public Director(double sueldo)
    {
        this.sueldo = sueldo;
    }
    public double GetSueldo()
    {
        return this.sueldo;
    }
}
class Secretaria : IParaEmpleados
{
    private double sueldo;

    public Secretaria(double sueldo)
    {
        this.sueldo = sueldo;
    }
    public double GetSueldo()
    {
        return this.sueldo;
    }
}
class Profesor
{
    private double sueldo;

    public Profesor(double sueldo)
    {
        this.sueldo = sueldo;
    }

}