using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("Pilot")]
    public class Pilot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Heart { get; set; }
        public int Rage { get; set; }
        public int Power { get; set; }
        public int MaxFightingSpirit { get; set; }
        public string MainImage { get; set; }
    }
}