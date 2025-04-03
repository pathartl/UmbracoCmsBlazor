using Umbraco.Cms.Blazor.Models;

namespace Umbraco.Cms.Blazor.Services;

public class ContentService(HttpClient httpClient) : BaseDeliveryService(httpClient)
{
    public async Task<PagedViewModel<ApiContentResponse>> GetAsync(
        string fetch = "",
        IEnumerable<string> filter = null,
        IEnumerable<string> sort = null,
        int skip = 0,
        int take = 25,
        string expand = "",
        string fields = "properties[$all]")
    {
        return await GetRequestAsync<PagedViewModel<ApiContentResponse>>("/content", new {
            Fetch = fetch,
            Filter = filter,
            Sort = sort,
            Skip = skip,
            Take = take,
            Expand = expand,
            Fields = fields
        });
    }

    public async Task<ApiContentResponse> GetByPathAsync(string path, string expand = "", string fields = "properties[$all]")
    {
        return await GetRequestAsync<ApiContentResponse>($"/content/item/{path}", new
        {
            Expand = expand,
            Fields = fields,
        });
    }

    public async Task<ApiContentResponse> GetByIdAsync(Guid id, string expand = "", string fields = "properties[$all]")
    {
        return await GetRequestAsync<ApiContentResponse>($"/content/item/{id}", new
        {
            Expand = expand,
            Fields = fields,
        });
    }

    public async Task<PagedViewModel<ApiContentResponse>> GetByIdsAsync(IEnumerable<Guid> ids, string expand = "",
        string fields = "properties[$all]")
    {
        return await GetRequestAsync<PagedViewModel<ApiContentResponse>>("/content/items", new
        {
            ids = ids.Select(i => i.ToString()).ToArray(),
            Expand = expand,
            Fields = fields,
        });
    }
}