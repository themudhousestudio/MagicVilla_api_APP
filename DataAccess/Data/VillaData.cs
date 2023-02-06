using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class VillaData : IVillaData
{
    private readonly ISqlDataAccess _db;

    public VillaData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<VillaModel>> GetVillas() =>
        _db.LoadData<VillaModel, dynamic>("dbo.spVilla_GetAll", new { });

    public async Task<VillaModel?> GetVilla(int id)
    {
        var results = await _db.LoadData<VillaModel, dynamic>(
            "dbo.spVilla_Get",
            new { Id = id }
            );
        return results.FirstOrDefault();
    }

    public Task InsertVilla(VillaModel user) =>
        _db.SaveData("dbo.spVilla_Insert", new { user.villa_name });

    public Task UpdateVilla(VillaModel user) =>
        _db.SaveData("dbo.spVilla_Update", user);

    public Task DeleteVilla(int id) =>
        _db.SaveData("dbo.spVilla_Delete", new { Id = id });
}