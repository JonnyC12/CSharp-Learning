namespace interfaces
{
    internal class Caballo : Mamifero, IMamiferoTerrestre, IMamiferoConPatas
    {
        private int patas;

        public Caballo(string Nombre, string Tipo, int patas) : base(Nombre, Tipo)
        {
            this.patas = patas;
        }

        public void PresentandoCaballo()
        {
            Console.WriteLine($"Hola soy un caballo con el siguiente número de patas{patas}");
        }
        // De esta manera implementamos la interfaz dentro del método
        //! De esta forma se implementa dos metodos con el mismo nombre en distintas interfaces, tenemos que quitarle el modificador de acceso ya que ahora 
        //! son método private que para saber a que interfaz pertenece el metodo que llamamos tendremoss que usar el principio de sustucion para convertirlos en objetos de su respectiva interfaz. 
        int IMamiferoConPatas.NumeroDePatas()
        {
            return this.patas;
        }
        int IMamiferoTerrestre.NumeroDePatas()
        {
            return this.patas;
        }



        public string Correr()
        {
            return "Estoy corriendo";
        }

    }
}