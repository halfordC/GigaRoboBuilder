using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("RobotCard")]
    public class RobotCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public bool IsUltimate { get; set; }
        public string CardType { get; set; }
        public string SubType { get; set; }
        public int CoolDown { get; set; }
        public int BaseDamage { get; set; }
        public int AttackDice { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public int Reach { get; set; }
        
        public string MainArt { get; set; }

        //other art needs to go here as well. 

    }
}