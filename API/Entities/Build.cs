using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("Builds")]
    public class Build
    {
        public int Id { get; set; }
        public AppUser BuildOwner { get; set; }
        public string Name { get; set; }
        public Robot ChosenRobot { get; set; }
        public Pilot ChosenPilot { get; set; }
        public ICollection<RobotCard> RobotCardList { get; set; }
        public ICollection<PilotCard> PilotCardList { get; set; }
        public PilotAbility ChosenPilotAbility { get; set; }
        public ICollection<RobotAbility> RobotAbilityList { get; set; }

        //methods to consider adding: Build Verification. Is this a valid build? Does it meet all requirnments? 

    }
}