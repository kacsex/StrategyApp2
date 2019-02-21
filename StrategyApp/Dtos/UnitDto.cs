using StrategyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyApp.Dtos
{
    public class UnitDto
    {
        public UnitDto(Unit u)
        {
            this.Id = u.Id;
            this.Name = u.Name;

            this.AttackPower = u.AttackPower;
            this.DefensePower = u.DefensePower;
            this.Price = u.Price;
            this.Salary = u.Salary;
            this.PotatoRequirement = u.PotatoRequirement;

        }
        public UnitDto()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int AttackPower { get; set; }
        public int DefensePower { get; set; }
        public int Price { get; set; }
        public int Salary { get; set; }
        public int PotatoRequirement { get; set; }
    }
}
