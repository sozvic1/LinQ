using HomeTask4;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> car = new List<Car>
            {
                new Car("BMW","X5",2005,"yelow"),
                new Car("Audi","A4",2010,"blue"),
                new Car("Ford","Fiesta",2016,"black"),
                new Car("BMW","X3",2016,"black")
            };

            List<Buyer> buyer = new List<Buyer>
            {
                new Buyer("Ivan","Fiat","0939232233"),
                new Buyer("Alex","BMW","0730800234"),
                new Buyer("Serg","Ford","0973452346")
            };
                      

            var info = from person in buyer
                        join auto in car on person.Model equals auto.Model
                        select new
                        {
                            Name = person.Name,
                            Telephone = person.NumberPhone,
                            Model = person.Model,
                            Color = auto.Color,
                            Brend = auto.Brend,
                            Year = auto.Year
                        };

            foreach (var item in info)
            {
                Console.WriteLine($"{item.Name}, {item.Telephone}, {item.Model}, {item.Color}, {item.Brend}, {item.Year} ");
            }
        }
    }
}
