using RestSharp;

namespace Umbraco.Cms.Blazor.Services;

public abstract class BaseService(HttpClient httpClient)
{
    protected abstract string BaseRoute { get; }
    protected RestClient Client = new RestClient(httpClient);

    protected async Task<TResponse?> GetRequestAsync<TResponse>(string route, object parameters)
    {
        return await Client.GetAsync<TResponse>(BaseRoute + route, parameters);
    }
}