using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.MapControllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get (string Name)
    {
      var query = _db.Animals.AsQueryable();

      if (Name != null)
      {
        query = query.Where(entry => entry.Name == Name);
      }

      return await query.ToListAsync();
    }
  }
}

