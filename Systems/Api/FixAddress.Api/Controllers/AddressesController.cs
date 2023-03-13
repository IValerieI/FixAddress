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

    /// <summary>
    /// Возвращает AddressResponse с частью парметров из ответа от dadata
    /// </summary>
    /// <param name="brokenAddress"></param>
    /// <returns></returns>
    [HttpGet("")]
    public async Task<AddressResponse> GetAddress([FromQuery] string brokenAddress)
    {
        var address = await addressService.GetAddress(brokenAddress);
        var response = mapper.Map<AddressResponse>(address);

        return response;
    }

    /// <summary>
    /// Возвращает полностью ответ от dadata
    /// </summary>
    /// <param name="brokenAddress"></param>
    /// <returns></returns>
    [HttpGet("detail")]
    public async Task<string> GetAddressDetail([FromQuery] string brokenAddress)
    {
        System.Diagnostics.Debug.WriteLine(brokenAddress);
        var result = await addressService.GetAddressDetail(brokenAddress);
        System.Diagnostics.Debug.WriteLine("        !!!" + brokenAddress);

        return result;
    }


}
