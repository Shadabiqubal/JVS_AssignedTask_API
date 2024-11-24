using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Repository.IRepositories
{
    public interface IVendorRepository
    {
        Task<int> SaveVendor(Vendor vendor);
        Task<IEnumerable<Vendor>> GetVendors();
        Task<int> DeleteVendor(int vendorId);
    }
}
