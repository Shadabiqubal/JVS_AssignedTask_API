using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using DataAccessLibrary.DataAccessLayer.Repository.IRepositories;
using DataAccessLibrary.DataAccessLayer.Service.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Service.Services
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _vendorRepository;
        public VendorService(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public async Task<IEnumerable<Vendor>> GetVendors()
        {
            return await _vendorRepository.GetVendors();
        }

        public async Task<int> SaveVendor(Vendor vendor)
        {
            return await _vendorRepository.SaveVendor(vendor);
        }
        
        public async Task<int> DeleteVendor(int vendorId)
        {
            return await _vendorRepository.DeleteVendor(vendorId);
        }
    }
}
