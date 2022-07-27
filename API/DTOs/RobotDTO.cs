using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RobotDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public int MaxArmour { get; set; }
        public int Defence { get; set; }
        
    }
}