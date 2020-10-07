using System;
using System.Security.Claims;
using weighmyslack.Models;
using weighmyslack.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace weighmyslack.Controllers
{
  [Authorize]
  [ApiController]
  [Route("api/[controller]")]
  public class RigController : ControllerBase
  {
    private readonly RigService _rs;
    private readonly RigComponentsService _rcs;

    public RigController(RigService rs, RigComponentsService rcs)
    {
      _rs = rs;
      _rcs = rcs;

    }


    [Authorize]
    [HttpGet("{rigId}/components")]
    public ActionResult<RigComponent> GetComponentsByRigId(int rigId)
    {
      try
      {
        return Ok(_rcs.GetComponentsByRigId(rigId));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

  }
}