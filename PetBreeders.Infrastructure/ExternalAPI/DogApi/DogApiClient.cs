using System.Text;
using PetBreeders.Application.Common.Interfaces;

namespace PetBreeders.Infrastructure.ExternalAPI.DogApi;

public partial class DogApiClient : IDogApiClient
{
    private string _baseUrl = "http://api.thedogapi.com";
    private readonly HttpClient _httpClient;
    private Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

    public DogApiClient(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("DogApiClient");
        _baseUrl = _httpClient.BaseAddress.ToString();
        _settings = new Lazy<Newtonsoft.Json.JsonSerializerSettings>(() =>
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            UpdateJsonSerializerSettings(settings);
            return settings;
        });
    }

    protected Newtonsoft.Json.JsonSerializerSettings jsonSerializerSettings
    {
        get { return _settings.Value; }
    }

    partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

    public string BaseUrl
    {
        get { return _baseUrl; }
        set { _baseUrl = value; }
    }

    public async Task<string> GetBreeds(string searchFilter, CancellationToken cancellationToken)
    {
        var urlBuilder = new StringBuilder();
        urlBuilder.Append(BaseUrl ??= "").Append("v1/breeds");
        urlBuilder.Append("/search?q=");
        urlBuilder.Append(searchFilter);

        var client = _httpClient;

        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Get;
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return responseData;
                }
                else
                {
                    return "Something bad happened";
                }
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public async Task<string> GetBreedDetail(int breedId, CancellationToken cancellationToken)
    {
        var urlBuilder = new StringBuilder();
        urlBuilder.Append(BaseUrl ??= "").Append("v1/breeds");
        urlBuilder.Append($"/{breedId}");

        var client = _httpClient;

        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Get;
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return responseData;
                }
                else
                {
                    return "Something bad happened";
                }
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public async Task<string> GetBreedImage(string breedImageId, CancellationToken cancellationToken)
    {
        var urlBuilder = new StringBuilder();
        urlBuilder.Append(BaseUrl ??= "").Append("v1/images");
        urlBuilder.Append($"/{breedImageId}");

        var client = _httpClient;

        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Get;
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return responseData;
                }
                else
                {
                    return "Something bad happened";
                }
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
