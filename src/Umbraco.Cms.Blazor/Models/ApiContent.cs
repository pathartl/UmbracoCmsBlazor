using System.Text.Json;
using System.Text.Json.Serialization;
using Umbraco.Cms.Core.Models.DeliveryApi;

namespace Umbraco.Cms.Blazor.Models;

/// <summary>
/// Shim to avoid IApiContentRoute on the ApiContentResponse model in Umbraco.Cms.Core
/// </summary>
public class ApiContent<TPublishedElement> : ApiElement<TPublishedElement>
{
    [JsonConstructor]
    public ApiContent(Guid id, string name, string contentType, DateTime createDate, DateTime updateDate, ApiContentRoute route, TPublishedElement properties)
        : base(id, contentType, properties)
    {
        Name = name;
        CreateDate = createDate;
        UpdateDate = updateDate;
        Route = route;
    }

    public string Name { get; }
    public DateTime CreateDate { get; }
    public DateTime UpdateDate { get; }
    public ApiContentRoute Route { get; }
}