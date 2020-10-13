using System;
using System.Collections.Generic;
using weighmyslack.Models;
using weighmyslack.Repositories;

namespace weighmyslack.Services
{
  public class RigsService
  {
    private readonly RigsRepository _repo;
    public RigsService(RigsRepository repo)
    {
      _repo = repo;
    }

    public IEnumerable<Rig> GetMyRigs(string userId)
    {
      IEnumerable<Rig> foundRigs = _repo.GetByUser(userId);
      if (foundRigs == null)
      {
        throw new Exception("Invalid user Id");
      }
      return foundRigs;

    }

    internal object Create(Rig newRig)
    {
      return _repo.Create(newRig);
    }
  }
}