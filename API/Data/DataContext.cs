using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<PilotCard> PilotCards {get; set;}
        public DbSet<RobotCard> RobotCards { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Robot> Robots { get; set; }
        public DbSet<PilotAbility> PilotAbilities { get; set; }
        public DbSet<RobotAbility> RobotAbilities { get; set; }
        public DbSet<Build> Builds { get; set; }
    }
}