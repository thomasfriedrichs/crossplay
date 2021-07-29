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
  [Route("api/crossplay/categories")]
  [ApiController]
  [EnableCors("http://localhost:3000")]  
  public class CategoriesController : ControllerBase
  {
    private readonly CrossPlayContext _db;
    public CategoriesController(CrossPlayContext db)
    {
      _db = db;
    }

    //Get: api/crossplay/categoriess
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
    {
      return await _db.Categories.ToListAsync();
    } 

    //Get: api/crossplay/categories/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Category>> GetCategory(int id)
    {
        var category = await _db.Categories.FindAsync(id);

        if (category == null)
        {
            return NotFound();
        }

        return category;
    }
  }
}