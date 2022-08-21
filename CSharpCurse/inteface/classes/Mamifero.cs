namespace interfaces
{
    internal class Mamifero
    {
        private string Nombre;
        private string Tipo;

        public Mamifero(string Nombre, string Tipo)
        {
            this.Tipo = Tipo;
            this.Nombre = Nombre;

        }
        public void Presentandome()
        {
            Console.WriteLine($"Soy un Mamifero de tipo: {Tipo} y nombre: {Nombre}");
        }
    }
}