namespace absClass
{
    class Lagartija : Animales
    {
        private string nombre;

        public Lagartija(string nombre)
        {
            this.nombre = nombre;
        }
        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del reptil es:{nombre}");
        }

    }
}