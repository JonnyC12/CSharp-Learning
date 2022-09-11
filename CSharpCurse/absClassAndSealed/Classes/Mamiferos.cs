namespace absClass
{
    class Mamiferos : Animales
    {
        string nombre;

        public Mamiferos(string nombre)
        {
            this.nombre = nombre;
        }
        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del mamífero es {this.nombre}");
        }
        public virtual void Caminar()
        {
            throw new NotImplementedException();
        }

    }
}