using System;
using System.Collections.Generic;
using weighmyslack.Models;
using weighmyslack.Repositories;

namespace weighmyslack.Services
{
  public class LineSlidesService
  {

    private readonly LineSlidesRepository _repo;

    public LineSlidesService(LineSlidesRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<LineSlide> Get()
    {
      return _repo.Get();
    }

    public LineSlide Create(LineSlide newLeashRing)
    {
      return _repo.Create(newLeashRing);
    }

    internal IEnumerable<LineSlide> GetLineSlidesByManufacturerId(int manufacturerId)
    {
      return _repo.GetLineSlidesByManufacturerId(manufacturerId);
    }
  }
}