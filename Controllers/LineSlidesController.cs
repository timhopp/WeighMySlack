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
  public class LineSlidesController : ControllerBase
  {
    private readonly LineSlidesService _lss;

    public LineSlidesController(LineSlidesService lss)
    {
      _lss = lss;
    }
    [HttpGet]
    public ActionResult<IEnumerable<LineSlide>> Get()
    {
      try
      {
        return Ok(_lss.Get());
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<LineSlide> Post([FromBody] LineSlide newLineSlide)
    {
      try
      {
        return Ok(_lss.Create(newLineSlide));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }


  }
}