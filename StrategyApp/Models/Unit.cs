using StrategyApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyApp.Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int AttackPower { get; set; }
        public int DefensePower { get; set; }
        public int Price { get; set; }
        public int Salary { get; set; }
        public int PotatoRequirement { get; set; }

        public ICollection<CountryUnit> CountryUnits { get; set; }


    }
}
