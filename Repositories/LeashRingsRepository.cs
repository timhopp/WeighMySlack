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
    internal IEnumerable<LeashRings> Get()
    {
      string sql = "SELECT * FROM LeashRings";
      return _db.Query<LeashRings>(sql);
    }

    internal LeashRings Create(LeashRings newLeashRings)
    {
      string sql = @"INSERT INTO LeashRings (id, manufacturerid, name, manufacturer, material, weight, wll, mbs, materialdiameter, innerdiameter, outerdiameter, price) VALUES (@id, @manufacturerid, @name, @manufacturer, @material, @weight, @wll, @mbs, @materialdiameter, @innerdiameter, @outerdiameter, @price); SELECT LAST_INSERT_ID();";
      newLeashRings.Id = _db.ExecuteScalar<int>(sql, newLeashRings);
      return newLeashRings;
    }
  }
}