using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("RobotAbility")]
    public class RobotAbility
    {
        public int Id { get; set; }
        public int RobotId { get; set; }
        public string Name { get; set; }
        public string Rules { get; set; }
        public int PowerTokens { get; set; }
        public string LogoImage { get; set; }
    }
}