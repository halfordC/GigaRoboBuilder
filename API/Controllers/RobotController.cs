using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    
    {
        private readonly IRobotRepository _robotRepository;
        private readonly IMapper _mapper;

        public RobotController(IRobotRepository robotRepository, IMapper mapper)
        {
            _mapper = mapper;
            _robotRepository = robotRepository;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<RobotDTO>>> GetRobots()
        {
            var robotArray = await _robotRepository.GetRobotsAsync();

            var robotsToReturn = _mapper.Map<IEnumerable<RobotDTO>>(robotArray);

            return Ok(robotsToReturn);
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<RobotDTO>> GetRobot(string name)
        {
            var robotReturned = await _robotRepository.GetRobotByNameAsync(name);
            return _mapper.Map<RobotDTO>(robotReturned);
        }

    }
}