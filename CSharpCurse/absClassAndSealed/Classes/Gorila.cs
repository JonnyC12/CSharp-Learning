namespace absClass
{
    //! Aplicando sealed sella la clase y no permite que chimpace hereda
    class Gorila : Mamiferos
    {
        int Patas;

        public Gorila(int Patas, string nombre) : base(nombre)
        {
            this.Patas = Patas;
        }
        public void Trepar()
        {
            throw new NotImplementedException();
        }
        public int numeroPatas()
        {
            throw new NotImplementedException();
        }
        public sealed override void Caminar()
        {
            Console.WriteLine("Estoy caminando y nadie lo puede cambiar");
        }

    }
}