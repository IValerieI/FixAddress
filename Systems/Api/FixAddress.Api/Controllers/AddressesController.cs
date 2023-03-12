using AutoMapper;
using FixAddress.Api.Controllers.Models;
using FixAddress.Services.Addresses;
using Microsoft.AspNetCore.Mvc;

namespace FixAddress.Api.Controllers;


[Route("api/clean/address")]
[ApiController]
public class AddressesController : ControllerBase
{
    private readonly IMapper mapper;
    private readonly IAddressService addressService;
    //private readonly ILogger<AddressController> logger;


    public AddressesController(IMapper mapper, IAddressService addressService)
    {
        this.mapper = mapper;
        this.addressService = addressService;
    }

    // when added async - can Task<string> for string
    [HttpGet("")]
    public async Task<AddressResponse> GetAddress([FromQuery] string brokenAddress)
    {
        var address = await addressService.GetAddress(brokenAddress);
        var response = mapper.Map<AddressResponse>(address);

        return response;
    }
}
