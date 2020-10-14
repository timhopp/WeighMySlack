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
      throw new NotImplementedException();
    }

    internal IEnumerable<RigComponentViewModel> GetComponentsByRigId(int rigId)
    {
      string sql = @"
       select lr.name as name, lr.id as id, lr.manufacturer as manufacturer, lr.componenttype as componenttype from leashrings lr,
       rigcomponents.id as rigcomponentId FROM RigComponents WHERE(rigcomponents.rigId = @rigId)
       union
       select ls.name as name, ls.id as id, ls.manufacturer as manufacturer, ls.componenttype as componenttype from lineslides ls,
       rigcomponents.id as rigcomponentId FROM RigComponents WHERE(rigcomponents.rigId = @rigId)
       union
       select w.name as name, w.id as id, w.manufacturer as manufacturer, w.componenttype as componenttype from webbings w,
       rigcomponents.id as rigcomponentId FROM RigComponents WHERE(rigcomponents.rigId = @rigId)
       union
       select wg.name as name, wg.id as id, wg.manufacturer as manufacturer, wg.componenttype as componenttype from webbingrips wg,
       rigcomponents.id as rigcomponentId FROM RigComponents WHERE(rigcomponents.rigId = @rigId)
       union 
       select wb.name as name, wb.id as id, wb.manufacturer as manufacturer, wb.componenttype as componenttype from weblocks wb,
       rigcomponents.id as rigcomponentId FROM RigComponents WHERE(rigcomponents.rigId = @rigId)";
      return _db.Query<RigComponentViewModel>(sql, new { rigId });
    }
  }
}