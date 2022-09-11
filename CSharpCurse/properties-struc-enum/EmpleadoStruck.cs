namespace Mistruck
{
    public struct EmpleadoStruck
    {
        public string nombre;
        public int salario;
        public EmpleadoStruck(string nombre, int salario)
        {
            this.nombre = nombre;
            this.salario = salario;
        }
        public void ModificarSalario(EmpleadoStruck emp, int salario)
        {
            emp.salario += salario;
        }




    }
}