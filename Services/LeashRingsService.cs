using System;
using System.Collections.Generic;
using weighmyslack.Models;
using weighmyslack.Repositories;

namespace weighmyslack.Services
{
  public class LeashRingsService
  {

    private readonly LeashRingsRepository _repo;

    public LeashRingsService(LeashRingsRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<LeashRing> Get()
    {
      return _repo.Get();
    }

    public LeashRing Create(LeashRing newLeashRing)
    {
      return _repo.Create(newLeashRing);
    }
  }
}