using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Repository.IRepositories
{
    public interface IMasterRepository
    {
        Task<IEnumerable<Country>> GetCountries();
        Task<IEnumerable<State>> GetStates(int countryId);
        Task<IEnumerable<City>> GetCities(int stateId);
        Task<IEnumerable<VendorType>> GetVendorTypes();
    }
}
