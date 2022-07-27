using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class RobotRepository : IRobotRepository
    {
        private readonly DataContext _context;
        public RobotRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Robot> GetRobotByIdAsync(int id)
        {
            return await _context.Robots.FindAsync(id);
        }

        public async Task<Robot> GetRobotByNameAsync(string name)
        {
            return await _context.Robots.SingleOrDefaultAsync(x => x.Name == name); //if robot Name == input name, return robot. 
        }

        public async Task<IEnumerable<Robot>> GetRobotsAsync()
        {
            return await _context.Robots.ToListAsync();
        }
    }
}