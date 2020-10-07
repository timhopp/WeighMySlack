using System;
using weighmyslack.Models;
using weighmyslack.Repositories;

namespace weighmyslack.Services
{

  public class ManufacturersService
  {
    private readonly ManufacturersRepository _repo;

    public ManufacturersService(ManufacturersRepository repo)
    {
      _repo = repo;
    }
    internal object Get()
    {
      return _repo.Get();
    }

    internal object Create(Manufacturer newManufacturer)
    {
      return _repo.Create(newManufacturer);
    }
  }
}