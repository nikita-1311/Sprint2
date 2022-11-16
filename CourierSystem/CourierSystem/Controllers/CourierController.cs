using CourierSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
  //[Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class CourierController : ControllerBase
  {
    CourierContext db = new CourierContext();
    [HttpGet]
    public IEnumerable<Courier> get()
    {
      return db.Couriers.ToList();
    }
    [HttpGet("{id}")]
    public Courier get(int id)
    {
      return db.Couriers.FirstOrDefault(o => o.CId == id);
    }
    [HttpPost]
    //[EnableCors("AllowOrigin")]
    public IActionResult post(Courier courier)
    {
      db.Couriers.Add(courier);
      db.SaveChanges();
      return Ok(new { status = "your record is added suceessfully" });
    }
    [HttpPut]
    public IActionResult put(Courier courier)
    {
      db.Couriers.Update(courier);
      db.SaveChanges();
      return Ok(new { status = "your record is updated suceessfully" });
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var courier = db.Couriers.FirstOrDefault(x => x.CId == id);
      db.Couriers.Remove(courier);
      db.SaveChanges();
      return Ok(new { status = "your record is deleted suceessfully" });
    }
  }
}
