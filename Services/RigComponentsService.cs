using System;
using weighmyslack.Models;
using System.Collections;
using System.Collections.Generic;
using weighmyslack.Repositories;

namespace weighmyslack.Services
{
  public class RigComponentsService
  {

    private readonly RigComponentRepository _repo;

    public RigComponentsService(RigComponentRepository repo)
    {
      _repo = repo;
    }
    internal RigComponent Create(RigComponent newRigComponent)
    {
      int id = _repo.Create(newRigComponent);
      newRigComponent.Id = id;
      return newRigComponent;
    }

    //Does this need to be a View Model??
    //How to get this to return multiple repo requests at once? 
    // public IEnumerable<RigComponent> GetComponentsByRigId(int rigId)
    // {
    //   return _repo.GetComponentsByRigId(rigId);

    // }

    public IEnumerable<LeashRingRigComponentViewModel> GetLeashRingsByRigId(int rigId)
    {
      return _repo.GetLeashRingsByRigId(rigId);
    }

    public IEnumerable<RigComponent> GetLineSlidesByRigId(int rigId)
    {
      return _repo.GetLineSlidesByRigId(rigId);
    }

    public IEnumerable<RigComponent> GetWebbingGripsByRigId(int rigId)
    {
      return _repo.GetWebbingGripsByRigId(rigId);
    }

    public IEnumerable<RigComponent> GetWeblocksByRigId(int rigId)
    {
      return _repo.GetWeblocksByRigId(rigId);
    }

    public IEnumerable<WebbingRigComponentViewModel> GetWebbingsByRigId(int rigId)
    {
      return _repo.GetWebbingsByRigId(rigId);
    }
  }
}