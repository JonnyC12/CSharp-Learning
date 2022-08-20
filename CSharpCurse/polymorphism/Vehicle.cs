namespace polymorphism
{
    internal class Vehicle
    {
        public decimal MaxSpeed;
        public int NumberWheels;
        public string Brand;
        public string Model;

        public Vehicle(string Brand, string Model)
        {
            this.Brand = Brand;
            this.Model = Model;
        }



        public virtual void Accelerate()
        {
            Console.WriteLine("speed up vehicle");
        }
        public void AccelerateOtherForm()
        {
            Console.WriteLine("Other form to speed up");
        }
    }
}