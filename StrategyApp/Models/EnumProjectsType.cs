using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyApp.Helper
{
    public enum EnumProjectsType
    {
        [Display(Name = "Tractor")]
        TRACTOR,
        [Display(Name = "Combine harvester")]
        COMBINE,
        [Display(Name = "City wall")]
        CITYWALL,
        [Display(Name = "Operation rebirth")]
        OP_REBIRTH,
        [Display(Name = "Tactics")]
        TACTICS,
        [Display(Name = "Alchemy")]
        ALCHEMY,
        [Display(Name = "Farm")]
        FARM,
        [Display(Name = "Barack")]
        BARACK
    }
}
