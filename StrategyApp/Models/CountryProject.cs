using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyApp.Models
{
    public class CountryProject
    {
        [Key]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int Number { get; set; }
        public int StartRound { get; set; }

    }
}
