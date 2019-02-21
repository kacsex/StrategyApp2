using StrategyApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyApp.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public EnumProjectsType Type { get; set; }

        public int RoundsToFinish { get; set; }

        public ICollection<CountryProject> CountryProjects { get; set; }

    }
}
