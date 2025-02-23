using ECC.Web.Shared.Models.Form;

namespace ECC.Web.Client.Services.Form;

public interface IFormService
{
    Task<FormDTO?> GetFormById(int id);
    Task<IEnumerable<string>> GetReligions();
    Task<IEnumerable<string>> GetEducationalLevels();
    Task<IEnumerable<string>> GetProfessions();
}
