using StrategyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyApp.Dtos
{
    public class CountryDto
    {
        public CountryDto(Country c)
        {
            this.Id = c.Id;
            this.Name = c.Name;

            this.PopulationNumber = c.PopulationNumber;
            this.GoldAmount = c.GoldAmount;
            this.PotatoAmount = c.PotatoAmount;
            this.Point = c.Point;
        }
        public CountryDto()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int PopulationNumber { get; set; }
        public int GoldAmount { get; set; }
        public int PotatoAmount { get; set; }
        public int Point { get; set; }
    }
}
