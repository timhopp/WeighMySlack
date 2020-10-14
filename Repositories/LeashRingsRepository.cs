using System;
using System.Collections.Generic;
using System.Data;
using weighmyslack.Models;
using Dapper;

namespace weighmyslack.Repositories
{

  public class LeashRingsRepository
  {
    private readonly IDbConnection _db;

    public LeashRingsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<LeashRing> Get()
    {
      string sql = "SELECT * FROM LeashRings";
      return _db.Query<LeashRing>(sql);
    }

    internal LeashRing Create(LeashRing newLeashRing)
    {
      string sql = @"INSERT INTO LeashRings (manufacturerid, name, img, manufacturer, componenttype, material, weight, wll, mbs, materialdiameter, innerdiameter, outerdiameter, price) VALUES (@manufacturerid, @name, @img, @manufacturer, @componenttype, @material, @weight, @wll, @mbs, @materialdiameter, @innerdiameter, @outerdiameter, @price); SELECT LAST_INSERT_ID();";
      newLeashRing.Id = _db.ExecuteScalar<int>(sql, newLeashRing);
      return newLeashRing;
    }

    internal IEnumerable<LeashRing> GetLeashRingsByManufacturerId(int manufacturerId)
    {
      string sql = "SELECT * FROM LeashRings WHERE manufacturerId = @manufacturerId";
      return _db.Query<LeashRing>(sql, new { manufacturerId });
    }
  }
}