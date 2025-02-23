
using ECC.Web.Shared.Models.Address;
using ECC.Web.Shared.Models.City;
using ECC.Web.Shared.Models.Country;
using ECC.Web.Shared.Models.State;

namespace ECC.Web.Client.Services.Location;

public class LocationService : ILocationService
{
    #region Properties
    #endregion

    #region Constructor
    #endregion

    #region Methods

    #region Get Countries
    public Task<IEnumerable<CountryDTO>> GetCountries()
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get Country By Id
    public Task<CountryDTO?> GetCountryById(int id)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get States
    public Task<IEnumerable<StateDTO>> GetStates()
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get State By UF
    public Task<StateDTO?> GetStateByUF(string UF)
    {
        throw new NotImplementedException();
    }
    #endregion
    
    #region Get Cities By UF
    public Task<IEnumerable<CityDTO>> GetCitiesByUF(string UF)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get Address By Zip Code
    public Task<IEnumerable<AddressDTO>> GetAddressByZipCode(string zipCode)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get Zip Code
    public Task<IEnumerable<AddressDTO>> GetZipCode(string UF, string city, string address)
    {
        throw new NotImplementedException();
    }
    #endregion

    #endregion
}
