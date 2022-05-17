using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("Robot")]
    public class Robot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public int MaxArmour { get; set; }
        public int Defence { get; set; }

    }
}