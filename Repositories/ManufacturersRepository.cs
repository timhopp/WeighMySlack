using System;
using System.Collections.Generic;
using System.Data;
using weighmyslack.Models;
using Dapper;

namespace weighmyslack.Repositories
{
  public class ManufacturersRepository
  {
    private readonly IDbConnection _db;

    public ManufacturersRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Manufacturer> Get()
    {
      string sql = @"SELECT * FROM Manufacturers";
      return _db.Query<Manufacturer>(sql);
    }

    internal object Create(Manufacturer newManufacturer)
    {
      string sql = @"INSERT INTO Manufacturers (yearestablished, website, facebook) VALUES (@yearestablished, @website, @facebook); SELECT LAST_INSERT_ID();";
      newManufacturer.Id = _db.ExecuteScalar<int>(sql, newManufacturer);
      return newManufacturer;
    }
  }
}