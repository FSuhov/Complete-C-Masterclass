namespace PolimorphismDemo
{
    class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowInfo()
        {
            System.Console.WriteLine("Brand " + brand + " Power "+HP+" Color" + Color);
        }

        public override void ShowDetails()
        {
            System.Console.WriteLine("Brand " + brand + " " + Model + " Power " + HP + " Color" + Color);
        }

        //sealed override используется только вместе.
        //препятствует переопределению в дочернем классе
        public sealed override void Repair()
        {
            System.Console.WriteLine("The BMW {0} has been repaird", Model);
        }
    }
}
