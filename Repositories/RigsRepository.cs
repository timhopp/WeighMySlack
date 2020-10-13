using System;
using System.Collections.Generic;
using System.Data;
using weighmyslack.Models;
using Dapper;

namespace weighmyslack.Repositories
{
  public class RigsRepository
  {
    private readonly IDbConnection _db;

    public RigsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal Rig Create(Rig newRig)
    {
      string sql = @"INSERT INTO Rigs
      (userid, name, description) VALUE (@userid, @name, @description);
      SELECT LAST_INSERT_ID();";
      newRig.Id = _db.ExecuteScalar<int>(sql, newRig);
      return newRig;
    }

    internal IEnumerable<Rig> GetByUser(string userId)
    {
      string sql = "SELECT * FROM Rigs WHERE userId = @UserId";
      return _db.Query<Rig>(sql, new { userId });
    }

  }
}