using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var fitnes = new List<Fitness>
            {
                new Fitness
                {
                    Code = 1,
                    Year = 1986,
                    Month = "Jully",
                    DurationWorkOut = 1
                },
                    new Fitness
                {
                    Code = 1,
                    Year = 2006,
                    Month = "April",
                    DurationWorkOut = 1
                },
                new Fitness
                {
                    Code = 2,
                    Year = 1985,
                    Month = "Junny",
                    DurationWorkOut = 1.20
                },

                new Fitness
                {
                    Code = 3,
                    Year = 1993,
                    Month = "Marth",
                    DurationWorkOut = 1.5
                },

                new Fitness
                {
                    Code = 4,
                    Year = 1994,
                    Month = "May",
                    DurationWorkOut = 2
                }

            };

            var element2 = fitnes.Where(x => x.DurationWorkOut == fitnes.Min(x => x.DurationWorkOut)).
                                  Last();                   
                Console.WriteLine($"Cod = {element2.Code}, " +
                    $"Year = {element2.Year}, Month = {element2.Month}, DurationWorkOut ={element2.DurationWorkOut} ");
            
           
        }
        public class Fitness
        {
            public int Code { get; set; }
            public int Year { get; set; }
            public string Month { get; set; }
            public double DurationWorkOut { get; set; }
        }
    }
}
