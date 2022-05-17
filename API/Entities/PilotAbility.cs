using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("PilotAbility")]
    public class PilotAbility
    {
        public int Id { get; set; }
        public int PilotId { get; set; }
        public string Name { get; set; }
        public string Rules { get; set; }

        public string MainArtImage { get; set; }
        //public string CooldownImage { get; set; }
        //public string DiceImage { get; set; }
        //public string DamageImage { get; set; }
        //public string TypeImage { get; set; }
        //public string CounterImage { get; set; }
        //public string ComboImage { get; set; }
        public string LogoImage { get; set; }
        
    }
}