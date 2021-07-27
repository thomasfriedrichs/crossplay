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
  [Route("api/crossplay/games")]
  [ApiController]
  public class GamesController : ControllerBase
  {
    private readonly CrossPlayContext _db;

    public GamesController(CrossPlayContext db)
    {
      _db = db;
    }
  
    // GET: api/crossplay/games
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Game>>> GetGames()
    {
      return await _db.Games.ToListAsync();
    } 

    // GET: api/crossplay/games/1
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
    
    //GET: api/platforms
    // [HttpGet]
    // // [Route("/platforms")]
    // public async Task<ActionResult<IEnumerable<Platform>>> GetPlatforms()
    // {
    //   return await _db.Platforms.ToListAsync();
    // }

    //[Route("/allgames")]
    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<Game>>> GetGames(string name)
    // {
    //   var query = _db.Games.AsQueryable();

    //   if (name != null)
    //   {
    //     query = query.Where(entry => entry.GameName == name);
    //   }      

    //   return await query.ToListAsync();
    // }


    // // GET: api/categories
    // [Route("/categories")]
    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<Category>>> GetCategories(string category)
    // {
    //   var query = _db.Categories.AsQueryable();

    //   if (category != null)
    //   {
    //     query = query.Where(entry => entry.CategoryName == category);
    //   }

    //   return await query.ToListAsync();
    // }

    // // GET: api/categories/5
    // [Route("/categories")]
    // [HttpGet("{id}")]
    // public async Task<ActionResult<Category>> GetCategory(int id)
    // {
    //     var category = await _db.Categories.FindAsync(id);

    //     if (category == null)
    //     {
    //         return NotFound();
    //     }

    //     return category;
    // }
  
    // // GET: api/Platforms
    // [Route("api/platforms")]
    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<Platform>>> GetPlatform(string platform)
    // {
    //   var query = _db.Platforms.AsQueryable();

    //   if (platform != null)
    //   {
    //     query = query.Where(entry => entry.PlatformName == platform);
    //   }

    //   return await query.ToListAsync();
    // }
  }
}