namespace PolimorphismDemo
{
    class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowInfo()
        {
            System.Console.WriteLine("Brand " + brand + " Power " + HP + " Color" + Color);
        }

        public override void ShowDetails()
        {
            System.Console.WriteLine("Brand " + brand + " " + Model + " Power " + HP + " Color" + Color);
        }

        public override void Repair()
        {
            System.Console.WriteLine("The Audi {0} has been repaird", Model);
        }
    }
}
