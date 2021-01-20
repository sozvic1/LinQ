using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Buyer
    {
        string name;
        string model { get; set; }     
        string numberPhone;

        public Buyer(string name, string model,string phone)
        {
            this.name = name;
            this.model = model;         
            this.numberPhone = phone;
        }
        public string Name { get; }
        public string Model { get; }
        public string NumberPhone { get; }
    }
}
