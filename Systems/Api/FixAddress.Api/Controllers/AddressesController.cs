using Dadata;
using Dadata.Model;
using Microsoft.AspNetCore.Mvc;

namespace FixAddress.Api.Controllers;


[Route("api/clean/address")]
[ApiController]
public class AddressesController : ControllerBase
{

    public AddressesController() { }

    // FromBody for sure?
    // when added async - can Task<string> for string
    //[HttpGet("findAddress")]
    public async Task<Address> GetAddress([FromQuery] string oldAddress)
    {
        var token = "f68cfa2adabf0f766554018492e3076488c8931c";
        var secret = "4f29142cef836bbeeebfbde9fe65221c6850a067";

        var api = new CleanClientAsync(token, secret);
        var result = await api.Clean<Address>(oldAddress);

        return result;
    }
}
