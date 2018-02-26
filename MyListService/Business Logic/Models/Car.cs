using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyListService.Business_Logic.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
        public int ProductionYear { get; set; }

        protected Car()
        {

        }

        public Car(string brand, string model, int horsepower, int productionYear)
        {
            Id = Guid.NewGuid();

            Brand = brand;
            Model = model;
            Horsepower = horsepower;
            ProductionYear = productionYear;
        }
    }
}
