

namespace Task2
{
    class Buyer
    {     
        public Buyer(string name, string model,string phone)
        {
            Name = name;
            Model = model;
            NumberPhone = phone;
        }
        public string Name { get; }
        public string Model { get; }
        public string NumberPhone { get; }
    }
}
