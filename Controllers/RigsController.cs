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
  public class RigsController : ControllerBase
  {
    private readonly RigsService _rs;
    private readonly RigComponentsService _rcs;

    public RigsController(RigsService rs, RigComponentsService rcs)
    {
      _rs = rs;
      _rcs = rcs;

    }

    //NOTE This still causes error, hmmm...
    [Authorize]
    [HttpGet("{rigId}/leashrings")]

    public ActionResult<RigComponent> GetLeashRingsByRigId(int rigId)
    {
      try
      {
        return Ok(_rcs.GetLeashRingsByRigId(rigId));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [Authorize]
    [HttpGet("{rigId}/lineslides")]
    public ActionResult<RigComponent> GetLineSlidesByByRigId(int rigId)
    {
      try
      {
        return Ok(_rcs.GetLineSlidesByRigId(rigId));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [Authorize]
    [HttpGet("{rigId}/webbinggrips")]
    public ActionResult<RigComponent> GetWebbingGripsByRigId(int rigId)
    {
      try
      {
        return Ok(_rcs.GetWebbingGripsByRigId(rigId));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [Authorize]
    [HttpGet("{rigId}/webbings")]
    public ActionResult<RigComponent> GetWebbingsByRigId(int rigId)
    {
      try
      {
        return Ok(_rcs.GetWebbingsByRigId(rigId));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [Authorize]
    [HttpGet("{rigId}/weblocks")]
    public ActionResult<RigComponent> GetWeblocksByRigId(int rigId)
    {
      try
      {
        return Ok(_rcs.GetWeblocksByRigId(rigId));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    // [Authorize]
    [HttpGet]
    public ActionResult<Rig> GetMyRigs()
    {
      try
      {
        // NOTE add once on front-end
        Claim user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
        if (user == null)
        {
          throw new Exception("You must be logged in to access your Rigs");
        }

        return Ok(_rs.GetMyRigs(user.Value));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }

    }

    [Authorize]
    [HttpPost]
    public ActionResult<Rig> Rig([FromBody] Rig newRig)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        newRig.UserId = userId;
        return Ok(_rs.Create(newRig));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }



  }
}