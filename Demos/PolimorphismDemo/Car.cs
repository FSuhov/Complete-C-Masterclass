namespace PolimorphismDemo
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        protected CarIDinfo carIDinfo = new CarIDinfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDinfo.IDNum = idNum;
            carIDinfo.Owner = owner;
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void GetCarIDInfo()
        {
            System.Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIDinfo.IDNum, carIDinfo.Owner);
        }

        public Car()
        {

        }

        //Метод, который будет в дочерних классах помечен как new
        public void ShowInfo()
        {
            System.Console.WriteLine("Power " + HP + ", color " + Color);
        }

        //Метод, который будет в дочерних классах переопределяться
        public virtual void ShowDetails()
        {
            System.Console.WriteLine("Power " + HP + ", color " + Color);
        }

        public virtual void Repair()
        {
            System.Console.WriteLine("Car has been repared");
        }

    }
}
