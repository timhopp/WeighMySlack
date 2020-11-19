using System;
using System.Collections.Generic;
using weighmyslack.Models;
using weighmyslack.Repositories;

namespace weighmyslack.Services
{
  public class WebbingsService
  {
    private readonly WebbingsRepository _repo;

    public WebbingsService(WebbingsRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<Webbing> Get()
    {
      return _repo.Get();
    }

    public Webbing Create(Webbing newWebbing)
    {
      return _repo.Create(newWebbing);
    }
  }
}