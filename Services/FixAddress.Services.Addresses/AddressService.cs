using AutoMapper;
using Dadata;
using Dadata.Model;
using Microsoft.Extensions.Configuration;
//using Newtonsoft.Json;

namespace FixAddress.Services.Addresses;


public class AddressService : IAddressService
{
    string url;
    private string token;
    private string secret;

    private readonly IMapper mapper;
    private readonly IConfiguration configuration;

    public AddressService(IMapper mapper, IConfiguration configuration)
    {
        this.mapper = mapper;
        this.configuration = configuration;

        this.token = configuration.GetSection("Token").Value;
        this.secret = configuration.GetSection("Secret").Value;
        this.url = configuration.GetSection("URL").Value;
    }


    /// <summary>
    /// Возвращает AddressModel с частью парметров из ответа от dadata
    /// </summary>
    /// <param name="brokenAddress"></param>
    /// <returns></returns>
    public async Task<AddressModel> GetAddress(string brokenAddress)
    {
        var api = new CleanClientAsync(token, secret);
        var address = await api.Clean<Address>(brokenAddress);

        var data = mapper.Map<AddressModel>(address);

        return data;
    }

    static HttpClient httpClient = new HttpClient();

    /// <summary>
    /// Возвращает полностью ответ от dadata
    /// </summary>
    /// <param name="brokenAddress"></param>
    /// <returns></returns>
    public async Task<string> GetAddressDetail(string brokenAddress)
    {
        StringContent content = new StringContent("[ \"" + brokenAddress + "\" ]", System.Text.Encoding.UTF8, "application/json");

        using var request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Content = content;

        request.Headers.Add("Authorization", "Token " + token);
        request.Headers.Add("X-Secret", secret);

        using var response = await httpClient.SendAsync(request);
        string responseText = await response.Content.ReadAsStringAsync();

        return responseText;

    }



}
