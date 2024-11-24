using DataAccessLibrary.DataAccessLayer.DBContext;
using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using DataAccessLibrary.DataAccessLayer.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Repository.Repositories
{
    public class MasterRepository:IMasterRepository
    {
        private readonly VendorDbContext _context;
        public MasterRepository(VendorDbContext vendorDbContext)
        {
            _context = vendorDbContext;
        }

        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<IEnumerable<State>> GetStates(int countryId)
        {
            return await _context.States.Where(s => s.CountryId == countryId).ToListAsync();
        }

        public async Task<IEnumerable<City>> GetCities(int stateId)
        {
            return await _context.Cities.Where(c => c.StateId == stateId).ToListAsync();
        }
        public async Task<IEnumerable<VendorType>> GetVendorTypes()
        {
            return await _context.VendorTypes.ToListAsync();
        }
    }
}
