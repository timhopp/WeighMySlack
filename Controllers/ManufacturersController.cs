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
  public class ManufacturersController : ControllerBase
  {
    private readonly ManufacturersService _ms;

    public ManufacturersController(ManufacturersService ms)
    {
      _ms = ms;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Manufacturer>> Get()
    {
      try
      {
        return Ok(_ms.Get());
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Manufacturer> Post([FromBody] Manufacturer newManufacturer)
    {
      try
      {
        return Ok(_ms.Create(newManufacturer));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }

    }
  }
}