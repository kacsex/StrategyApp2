using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyApp.Models
{
    public class CountryUnit
    {
        [Key]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int UnitId { get; set; }

        public int UnitNumber { get; set; }

        public Unit Unit { get; set; }
        public Country Country { get; set; }
    }
}
