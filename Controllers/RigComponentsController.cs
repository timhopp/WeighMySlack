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
  public class RigComponentsController : ControllerBase
  {
    private readonly RigComponentsService _rcs;

    public RigComponentsController(RigComponentsService rcs)
    {
      _rcs = rcs;
    }

    [HttpPost]
    public ActionResult<RigComponent> Create([FromBody] RigComponent newRigComponent)
    {
      try
      {
        Claim user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
        if (user == null)
        {
          throw new Exception("You must be logged in to add a keep to a vault");
        }
        newRigComponent.UserId = user.Value;
        return Ok(_rcs.Create(newRigComponent));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }


  }
}