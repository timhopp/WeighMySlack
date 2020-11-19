using System;
using System.Collections.Generic;
using weighmyslack.Models;
using weighmyslack.Services;
using Microsoft.AspNetCore.Mvc;

namespace weighmyslack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class WebbingsController : ControllerBase
  {
    private readonly WebbingsService _ws;

    public WebbingsController(WebbingsService ws)
    {
      _ws = ws;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Webbing>> Get()
    {
      try
      {
        return Ok(_ws.Get());
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [HttpPost]
    public ActionResult<Webbing> Post([FromBody] Webbing newWebbing)
    {
      try
      {
        return Ok(_ws.Create(newWebbing));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}