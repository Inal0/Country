using Countries;
using System;
using System.Collections.Generic;

namespace Countries
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Country azerbaycan = new Country

            //{
            //    Name = "azerbaycan",
            //    City = new List<City>
            //    {
            //        new City { Name = "Baki", Population = 5000000 },
            //        new City { Name = "Gence", Population = 1000000 },
            //        new City { Name = "Baku", Population = 2200000 },
            //        new City { Name = "Samaxi", Population = 330000 },
            //        new City { Name = "Culfa", Population = 1100000 },
            //    }

            //};
            //Country Fransa = new Country();
            //City Baku = new City();
            //Fransa.City.Add(Baku);

            City city = new City("a", 1);


            City city1 = new City
            {
                Name = "a",
                Population = 1
        };
            

        }
    }  
}
