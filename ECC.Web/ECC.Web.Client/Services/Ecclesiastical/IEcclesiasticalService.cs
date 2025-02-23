using ECC.Web.Shared.Models.Parish;

namespace ECC.Web.Client.Services.Ecclesiastical;

public interface IEcclesiasticalService
{
    Task<IEnumerable<string>> GetRegions();
    Task<IEnumerable<string>> GetArchdiocesesByRegion(string region);
    Task<IEnumerable<ParishDTO>> GetParishesByArchdiocese(string archdiocese);
}
