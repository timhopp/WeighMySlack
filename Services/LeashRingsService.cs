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
    public IEnumerable<LeashRings> Get()
    {
      return _repo.Get();
    }

    public LeashRings Create(LeashRings newLeashRings)
    {
      return _repo.Create(newLeashRings);
    }
  }
}