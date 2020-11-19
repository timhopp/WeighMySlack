using System;
using System.Collections.Generic;
using System.Data;
using weighmyslack.Models;
using Dapper;

namespace weighmyslack.Repositories
{
  public class WebbingsRepository
  {
    private readonly IDbConnection _db;

    public WebbingsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Webbing> Get()
    {
      string sql = "SELECT * FROM Webbings";
      return _db.Query<Webbing>(sql);
    }

    internal Webbing Create(Webbing newWebbing)
    {
      string sql = @"INSERT INTO Webbings (manufacturerId, name, manufacturer, componentType, img, material, width, weight, wll, mbs, thickness, elongation) VALUE (@manufacturerId, @name, @manufacturer, @componentType, @img, @material, @width, @weight, @wll, @mbs, @thickness, @elongation)";
      newWebbing.Id = _db.ExecuteScalar<int>(sql, newWebbing);
      return newWebbing;
    }
  }

}