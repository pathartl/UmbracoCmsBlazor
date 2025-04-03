using Umbraco.Cms.Core.Models.DeliveryApi;

namespace Umbraco.Cms.Blazor.Models;

public class PagedViewModel<TResponse>
{
    public int Total { get; set; }
    public IEnumerable<TResponse> Items { get; set; }
}