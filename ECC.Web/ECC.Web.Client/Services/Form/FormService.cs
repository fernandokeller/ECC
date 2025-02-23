
using ECC.Web.Shared.Models.Form;

namespace ECC.Web.Client.Services.Form;

public class FormService : IFormService
{
    #region Properties
    #endregion

    #region Constructor
    #endregion

    #region Methods

    #region Get Form By Id
    public Task<FormDTO?> GetFormById(int id)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get Religions
    public Task<IEnumerable<string>> GetReligions()
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get Educational Levels
    public Task<IEnumerable<string>> GetEducationalLevels()
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get Professions
    public Task<IEnumerable<string>> GetProfessions()
    {
        throw new NotImplementedException();
    }
    #endregion

    #endregion
}
