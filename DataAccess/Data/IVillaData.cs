using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IVillaData
    {
        Task DeleteVilla(int id);
        Task<VillaModel?> GetVilla(int id);
        Task<IEnumerable<VillaModel>> GetVillas();
        Task InsertVilla(VillaModel user);
        Task UpdateVilla(VillaModel user);
    }
}