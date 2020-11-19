using System;
using System.Collections.Generic;
using weighmyslack.Models;
using weighmyslack.Services;
using Microsoft.AspNetCore.Mvc;



namespace weighmyslack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class WebbingGripsController : ControllerBase
  {
    private readonly WebbingGripsService _wgs;

    public WebbingGripsController(WebbingGripsService wgs)
    {
      _wgs = wgs;
    }
    [HttpGet]
    public ActionResult<IEnumerable<WebbingGrip>> Get()
    {
      try
      {
        return Ok(_wgs.Get());
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<WebbingGrip> Post([FromBody] WebbingGrip newWebbingGrip)
    {
      try
      {
        return Ok(_wgs.Create(newWebbingGrip));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

  }
}