using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using weighmyslack.Models;

namespace weighmyslack.Repositories
{
  public class RigComponentRepository
  {

    private readonly IDbConnection _db;

    public RigComponentRepository(IDbConnection db)
    {
      _db = db;
    }
    internal int Create(RigComponent newRigComponent)
    {
      string sql = @"
      INSERT INTO RigComponents
      (rigId, componentId, userId)
      VALUES
      (@RigId, @ComponentId, @userId);
      SELECT LAST_INSERT_ID()";
      return _db.ExecuteScalar<int>(sql, newRigComponent);
    }

    internal IEnumerable<LeashRingRigComponentViewModel> GetLeashRingsByRigId(int rigId)
    {
      string sql = @"
      SELECT
      leashrings.*,
      rigcomponents.id as rigComponentId
      FROM RigComponents
      INNER JOIN leashrings on leashrings.id = rigcomponents.componentId
      WHERE(rigcomponents.rigId = @rigId)
      ";
      return _db.Query<LeashRingRigComponentViewModel>(sql, new { rigId });
    }

    internal IEnumerable<WebbingRigComponentViewModel> GetWebbingsByRigId(int rigId)
    {
      string sql = @"
      SELECT
      webbings.*,
      rigcomponents.id as rigComponentId
      FROM RigComponents
      INNER JOIN webbings on webbings.id = rigcomponents.componentId
      WHERE(rigcomponents.rigId = @rigId)
      ";
      return _db.Query<WebbingRigComponentViewModel>(sql, new { rigId });
    }

    internal IEnumerable<RigComponent> GetWeblocksByRigId(int rigId)
    {
      throw new NotImplementedException();
    }

    internal IEnumerable<RigComponent> GetWebbingGripsByRigId(int rigId)
    {
      throw new NotImplementedException();
    }

    internal IEnumerable<RigComponent> GetLineSlidesByRigId(int rigId)
    {
      throw new NotImplementedException();
    }

  }
}