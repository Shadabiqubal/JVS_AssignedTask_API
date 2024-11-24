using DataAccessLibrary.DataAccessLayer.Service.IServices;
using DataAccessLibrary.DataAccessLayer.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VendorRegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMasterService _masterService;
        public MasterController(IMasterService masterService)
        {
            _masterService = masterService;
        }

        [HttpGet("GetCountries")]
        public async Task<IActionResult> GetCountries()
        {
            var countries = await _masterService.GetCountries();
            return Ok(countries);
        }

        [HttpGet("GetStates/{countryId}")]
        public async Task<IActionResult> GetStates(int countryId)
        {
            var states = await _masterService.GetStates(countryId);
            return Ok(states);
        }

        [HttpGet("GetCities/{stateId}")]
        public async Task<IActionResult> GetCities(int stateId)
        {
            var cities = await _masterService.GetCities(stateId);
            return Ok(cities);
        }

        [HttpGet("GetVendorTypes")]
        public async Task<IActionResult> GetVendorTypes()
        {
            var vendorTypes = await _masterService.GetVendorTypes();
            return Ok(vendorTypes);
        }
    }
}
