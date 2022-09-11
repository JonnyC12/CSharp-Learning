class Empleado
{
    // Campo salario private
    private double salario;
    // Otro campo private, con está convencion el menu intellisense no lo detecta, en versiones anteriores, pero ahora funciona correctamente
    private int _horasTrabajo;

    // Propiedad Salario para tener acceso al campo salario private
    // public double Salario
    // {
    //     get { return this.salario; }
    //     set
    //     {
    //         if (value < 0)
    //         {
    //             Console.WriteLine("Salario erroneo");
    //             salario = 0;
    //         }
    //         else
    //         {
    //             this.salario = value;
    //         }
    //     }
    // }
    //! simplificacion con funciones lambda

    public double Salario
    {
        get => this.salario;
        set => this.salario = value;
    }

    public int HorasTrabajo
    {
        get => this._horasTrabajo;
        set => this._horasTrabajo = value;
    }

    private string nombre;
    public Empleado(string nombre)
    {
        this.nombre = nombre;
    }
    public void AumentarSalario(Empleado emp, double salario)
    {
        emp.Salario += salario;
    }

    public void AplicarExtra(aumentos tipoAumento)
    {
        this.salario = ((double)tipoAumento) * this.salario;
    }
}