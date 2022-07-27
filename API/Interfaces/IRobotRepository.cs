using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IRobotRepository
    {
        //no need to change robots, or save changes. only need to get them. 

        Task<IEnumerable<Robot>> GetRobotsAsync();

        Task<Robot> GetRobotByIdAsync(int id);

        Task<Robot> GetRobotByNameAsync(string name);
        
    }
}