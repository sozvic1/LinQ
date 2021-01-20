

namespace HomeTask4
{
    class Car
    {
        public string Model { get; set; }
        public string Brend { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string model,string brend, int year,string color)
        {
            Model = model;
            Brend = brend;
            Year = year;
            Color = color;
        }
    }
}
