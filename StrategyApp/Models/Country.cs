using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyApp.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PopulationNumber { get; set; }
        public int GoldAmount { get; set; }
        public int PotatoAmount { get; set; }
        public int Point { get; set; }
        public ICollection<CountryProject> CountryProjects { get; set; }
        public ICollection<CountryUnit> CountryUnits { get; set; }
    }
}
