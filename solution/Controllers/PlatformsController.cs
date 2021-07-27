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
  [Route("api/crossplay/platforms")]
  [ApiController]
  public class PlatformsController : ControllerBase
  {
    private readonly CrossPlayContext _db;

    public PlatformsController(CrossPlayContext db)
    {
      _db = db;
    }
  }
}