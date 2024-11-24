using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Service.IServices
{
    public interface IVendorService
    {
        Task<IEnumerable<Vendor>> GetVendors();
        Task<int> SaveVendor(Vendor vendor);
        Task<int> DeleteVendor(int vendorId);
    }
}
