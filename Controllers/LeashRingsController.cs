using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using weighmyslack.Models;
using weighmyslack.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace weighmyslack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class LeashRingsController : ControllerBase
  {
    private readonly LeashRingsService _lrs;

    public LeashRingsController(LeashRingsService lrs)
    {
      _lrs = lrs;
    }
    [HttpGet]
    public ActionResult<IEnumerable<LeashRings>> Get()
    {
      try
      {
        return Ok(_lrs.Get());
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<LeashRings> Post([FromBody] LeashRings newLeashRings)
    {
      try
      {
        return Ok(_lrs.Create(newLeashRings));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }


  }
}