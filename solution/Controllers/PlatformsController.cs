using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrossPlay.Models;
using Microsoft.AspNetCore.Cors;

namespace CrossPlay.Controllers
{
  [Route("api/crossplay/platforms")]
  [ApiController]
  [EnableCors("http://localhost:3000")]  

  public class PlatformsController : ControllerBase
  {
    private readonly CrossPlayContext _db;
    public PlatformsController(CrossPlayContext db)
    {
      _db = db;
    }

    //Get: api/crossplay/platforms
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Platform>>> GetPlatforms()
    {
      return await _db.Platforms.ToListAsync();
    } 

    //Get: api/crossplay/platforms/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Platform>> GetPlatform(int id)
    {
        var platform = await _db.Platforms.FindAsync(id);

        if (platform == null)
        {
            return NotFound();
        }

        return platform;
    }
  }
}