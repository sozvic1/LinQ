using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new Dictionary<dynamic, dynamic>
            {
                {"Mother","мама" },
                {"Dog","Собака" },
                {"Neture","Природа" },
                {"Father","отец" },
                {"Douther","дочь" },
                {"Sun","cын" }
               
            };
            foreach (var item in myDictionary)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }
      
        }
          
        
    }
}
