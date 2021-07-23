using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrossPlay.Models;

namespace CrossPlay.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class GamesController : ControllerBase
  {
    private readonly CrossPlayContext _db;

    public GamesController(CrossPlayContext db)
    {
      _db = db;
    }

    // GET: api/Games
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Game>>> Get(string category, string name)
    {
      var query = _db.Games.AsQueryable();

      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }      

      return await query.ToListAsync();
    }

    // GET: api/Games/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> GetGame(int id)
    {
        var game = await _db.Games.FindAsync(id);

        if (game == null)
        {
            return NotFound();
        }

        return game;
    }
  }
}