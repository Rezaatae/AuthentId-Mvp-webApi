using AuthentIdMobileMvpWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthentIdMobileMvpWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AuthentIdDbContext _dbContext;

        public UserController(AuthentIdDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("LoginUser/{email}/{password}")]
        public async Task<ActionResult<AuthentIdUser>> LoginUser(string email, string password)
        {
            if (_dbContext.AuthentIdUsers == null)
            {
                return NotFound();
            }

            var userInfo = _dbContext.AuthentIdUsers.Where(u => u.Email == email && u.Password == password);
            if(userInfo == null)
            {
                return NotFound();
            }

            return Ok(userInfo);

        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<AuthentIdScan>>> GetUserScans(int userId)
        {
            if (_dbContext.AuthentIdScans == null)
            {
                return NotFound();
            }
            var userScans = await _dbContext.AuthentIdScans.Where(s => s.UserId == userId).ToListAsync();
            if (userScans == null)
            {
                return NotFound();
            }
            return userScans;
        }
    }
}
