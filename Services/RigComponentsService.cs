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
    internal IEnumerable<RigComponent> GetComponentsByRigId(int rigId)
    {
      return _repo.GetLeashRingsByRigId(rigId).GetWeblockByRigId(rigId);

    }
  }
}