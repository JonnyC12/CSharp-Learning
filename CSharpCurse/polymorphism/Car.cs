namespace polymorphism
{
    internal class Car : Vehicle
    {
        public int Cilindrada { get; set; }

        public Car(int Cilindrada, string Brand, string Model) : base(Brand, Model)
        {
            this.Cilindrada = Cilindrada;
        }
        // One form usig virtual in Father method class and override in son class
        public override void Accelerate()
        {
            Console.WriteLine("speed up CAR");
        }
        // Second form using new to Override a Father method 
        public new void AccelerateOtherForm()
        {
            Console.WriteLine("Other form to speed up when use Car");
        }
    }
}