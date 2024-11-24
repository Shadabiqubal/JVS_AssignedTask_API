using DataAccessLibrary.DataAccessLayer.DBContext;
using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using DataAccessLibrary.DataAccessLayer.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataAccessLibrary.DataAccessLayer.Repository.Repositories
{
    public class VendorRepository:IVendorRepository
    {
        private readonly VendorDbContext _context;
        public VendorRepository(VendorDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveVendor(Vendor vendor)
        {
            vendor.Code = GenerateVendorCode();
            _context.Vendors.Add(vendor);
            var result=await _context.SaveChangesAsync();
            return result;
        }

        public async Task<IEnumerable<Vendor>> GetVendors()
        {
            return await _context.Vendors
                .Include(v => v.VendorType)
                .Include(v => v.Country)
                .Include(v => v.State)
                .Include(v => v.City)
                .ToListAsync();
        }

        public async Task<int> DeleteVendor(int vendorId)
        {
            var vendor = await _context.Vendors.FindAsync(vendorId);
            if (vendor == null)
            {
                return 0;
            }

            _context.Vendors.Remove(vendor);
            var result = await _context.SaveChangesAsync();
            return result;
        }




        public string GenerateVendorCode()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
        }

    }
}
