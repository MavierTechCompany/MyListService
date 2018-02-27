using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyListService.Business_Logic.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
        public int ProductionYear { get; set; }

        public Car()
        {
            
        }
    }
}
