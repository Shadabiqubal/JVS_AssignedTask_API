using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using DataAccessLibrary.DataAccessLayer.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace VendorRegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService _vendorService;
        private readonly IErrorHandlingService _errorHandlingService;
        public VendorController(IVendorService vendorService, IErrorHandlingService errorHandlingService)
        {
            _vendorService = vendorService;
            _errorHandlingService = errorHandlingService;
        }

        [HttpGet("GetVendors")]
        public async Task<ActionResult<IEnumerable<Vendor>>> GetVendors()
        {
            return Ok(await _vendorService.GetVendors());
        }

        [HttpPost("SaveVendor")]
        public async Task<ActionResult<int>> SaveVendor(Vendor vendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (vendor == null)
                return BadRequest("Invalid vendor data.");
            return await _vendorService.SaveVendor(vendor);

        }
        [HttpDelete("DeleteVendor")]
        public async Task<ActionResult<int>> DeleteVendor(int vendorId)
        {
            if (vendorId < 1)
                return BadRequest("Invalid vendorId.");
            return await _vendorService.DeleteVendor(vendorId);

        }
    }
}
