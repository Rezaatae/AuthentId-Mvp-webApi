using AuthentIdMobileMvpWebApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthentIdMobileMvpWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScanController : ControllerBase
    {
        private readonly AuthentIdDbContext _dbContext;

        public ScanController(AuthentIdDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AuthentIdScan>> GetScanById(int id)
        {
            if (_dbContext.AuthentIdScans == null)
            {
                return NotFound();
            }
            var authentIDScan = await _dbContext.AuthentIdScans.FindAsync(id);
            if (authentIDScan == null)
            {
                return NotFound();
            }
            return authentIDScan;
        }

        [HttpPost]
        public async Task<ActionResult<AuthentIdScan>> PostAuthentIDScan(AuthentIdScan authentIdScan)
        {
            _dbContext.AuthentIdScans.Add(authentIdScan);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetScanById), new { id = authentIdScan.Id }, authentIdScan);
        }
    }
}
