using ECC.Web.Shared.Models.Address;
using ECC.Web.Shared.Models.City;
using ECC.Web.Shared.Models.Country;
using ECC.Web.Shared.Models.State;

namespace ECC.Web.Client.Services.Location;

public interface ILocationService
{
    Task<IEnumerable<CountryDTO>> GetCountries();
    Task<CountryDTO?> GetCountryById(int id);
    Task<IEnumerable<StateDTO>> GetStates();
    Task<StateDTO?> GetStateByUF(string UF);
    Task<IEnumerable<CityDTO>> GetCitiesByUF(string UF);
    Task<IEnumerable<AddressDTO>> GetAddressByZipCode(string zipCode);
    Task<IEnumerable<AddressDTO>> GetZipCode(string UF, string city, string address);
}
