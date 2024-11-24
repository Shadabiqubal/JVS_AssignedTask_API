using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using DataAccessLibrary.DataAccessLayer.Repository.IRepositories;
using DataAccessLibrary.DataAccessLayer.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Service.Services
{
    public class MasterService:IMasterService
    {
        private readonly IMasterRepository _masterRepository;

        public MasterService(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }

        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await _masterRepository.GetCountries();
        }

        public async Task<IEnumerable<State>> GetStates(int countryId)
        {
            return await _masterRepository.GetStates(countryId);
        }

        public async Task<IEnumerable<City>> GetCities(int stateId)
        {
            return await _masterRepository.GetCities(stateId);
        }

        public async Task<IEnumerable<VendorType>> GetVendorTypes()
        {
            return await _masterRepository.GetVendorTypes();
        }
    }
}
