using System;
using System.Collections.Generic;
using System.Data;
using weighmyslack.Models;
using Dapper;

namespace weighmyslack.Repositories
{

  public class LineSlidesRepository
  {
    private readonly IDbConnection _db;

    public LineSlidesRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<LineSlide> Get()
    {
      string sql = "SELECT * FROM LineSlides";
      return _db.Query<LineSlide>(sql);
    }

    internal LineSlide Create(LineSlide newLineSlide)
    {
      string sql = @"INSERT INTO LineSlides (manufacturerid, name, img, manufacturer, componenttype, material, weight, wll, mbs, materialdiameter, innerdiameter, outerdiameter, price) VALUES (@manufacturerid, @name, @img, @manufacturer, @componenttype, @material, @weight, @wll, @mbs, @materialdiameter, @innerdiameter, @outerdiameter, @price); SELECT LAST_INSERT_ID();";
      newLineSlide.Id = _db.ExecuteScalar<int>(sql, newLineSlide);
      return newLineSlide;
    }

    internal IEnumerable<LineSlide> GetLineSlidesByManufacturerId(int manufacturerId)
    {
      string sql = "SELECT * FROM LineSlides WHERE manufacturerId = @manufacturerId";
      return _db.Query<LineSlide>(sql, new { manufacturerId });
    }
  }
}