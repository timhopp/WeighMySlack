using System;
using System.Collections.Generic;
using weighmyslack.Models;
using weighmyslack.Repositories;

namespace weighmyslack.Services
{
  public class WebbingGripsService
  {
    private readonly WebbingGripsRepository _repo;

    public WebbingGripsService(WebbingGripsRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<WebbingGrip> Get()
    {
      return _repo.Get();
    }

    public WebbingGrip Create(WebbingGrip newWebbingGrip)
    {
      return _repo.Create(newWebbingGrip);
    }
  }
}