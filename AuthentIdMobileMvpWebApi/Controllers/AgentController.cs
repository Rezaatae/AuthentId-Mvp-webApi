using AuthentIdMobileMvpWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthentIdMobileMvpWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly AuthentIdDbContext _dbContext;

        public AgentController(AuthentIdDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AuthentIdAgent>> GetAgentByIdAsync(int id)
        {
            if(_dbContext.AuthentIdAgents == null)
            {
                return NotFound();
            }

            var agents = await _dbContext.AuthentIdAgents.FindAsync(id);
            if(agents == null)
            {
                return NotFound();
            }
            return agents;
        }
    }
}
