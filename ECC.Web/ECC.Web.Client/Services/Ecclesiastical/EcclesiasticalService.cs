
using ECC.Web.Shared.Models.Parish;

namespace ECC.Web.Client.Services.Ecclesiastical;

public class EcclesiasticalService : IEcclesiasticalService
{
    #region Properties
    #endregion

    #region Constructor
    #endregion

    #region Methods

    #region Get Regions
    public Task<IEnumerable<string>> GetRegions()
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get Archdioceses By Region
    public Task<IEnumerable<string>> GetArchdiocesesByRegion(string region)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get Parishes By Archdiocese
    public Task<IEnumerable<ParishDTO>> GetParishesByArchdiocese(string archdiocese)
    {
        throw new NotImplementedException();
    }
    #endregion

    #endregion
}
