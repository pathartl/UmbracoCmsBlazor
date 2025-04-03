using Umbraco.Cms.Blazor.Models;
using Umbraco.Cms.Core.Models.DeliveryApi;
using ApiContentResponse = Umbraco.Cms.Blazor.Models.ApiContentResponse;

namespace Umbraco.Cms.Blazor.Services;

public class MediaService(HttpClient httpClient) : BaseDeliveryService(httpClient)
{
    public async Task<PagedViewModel<ApiContentResponse>> GetAsync(
        string fetch = "",
        IEnumerable<string> filter = null,
        IEnumerable<string> sort = null,
        int skip = 0,
        int take = 25,
        string expand = "",
        string fields = "")
    {
        return await GetRequestAsync<PagedViewModel<ApiContentResponse>>("/media", new {
            Fetch = fetch,
            Filter = filter,
            Sort = sort,
            Skip = skip,
            Take = take,
            Expand = expand,
            Fields = fields
        });
    }

    public async Task<IApiMediaWithCropsResponse> GetAsync(string path, string expand = "", string fields = "")
    {
        return await GetRequestAsync<IApiMediaWithCropsResponse>($"/media/item/{path}", new
        {
            Expand = expand,
            Fields = fields,
        });
    }

    public async Task<IApiMediaWithCropsResponse> GetAsync(Guid id, string expand = "", string fields = "")
    {
        return await GetRequestAsync<IApiMediaWithCropsResponse>($"/media/item/{id}", new
        {
            Expand = expand,
            Fields = fields,
        });
    }

    public async Task<IEnumerable<IApiMediaWithCropsResponse>> GetAsync(IEnumerable<Guid> ids, string expand = "",
        string fields = "")
    {
        return await GetRequestAsync<IEnumerable<IApiMediaWithCropsResponse>>("/media/items", new
        {
            ids = ids.Select(i => i.ToString()).ToArray(),
            Expand = expand,
            Fields = fields,
        });
    }
}