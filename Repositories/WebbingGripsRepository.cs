using System;
using System.Collections.Generic;
using System.Data;
using weighmyslack.Models;
using Dapper;

namespace weighmyslack.Repositories
{
  public class WebbingGripsRepository
  {
    private readonly IDbConnection _db;

    public WebbingGripsRepository(IDbConnection db)
    {
      _db = db;
    }

    public WebbingGrip Create(WebbingGrip newWebbingGrip)
    {
      string sql = @"INSERT INTO WebbingGrips (manufacturerId, name, manufacturer, img, componentType, material, weight, wll, mbs, commonSlipThreshold, connectionType, compatibleWebbingWidth, price) VALUE (@manufacturerId, @name, @manufacturer, @img, @componentType, @material, @weight, @wll, @mbs, @commonSlipThreshold, @connectionType, @compatibleWebbingWidth, @price) ";
      newWebbingGrip.Id = _db.ExecuteScalar<int>(sql, newWebbingGrip);
      return newWebbingGrip;
    }

    internal IEnumerable<WebbingGrip> Get()
    {
      string sql = "SELECT * FROM WebbingGrips";
      return _db.Query<WebbingGrip>(sql);
    }
  }
}