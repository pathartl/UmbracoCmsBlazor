using System.Text.Json;
using System.Text.Json.Serialization;

namespace Umbraco.Cms.Blazor.Models;

/// <summary>
/// Shim to avoid IApiContentRoute on the ApiContentResponse model in Umbraco.Cms.Core
/// </summary>
public class ApiContent : ApiElement
{
    [JsonConstructor]
    public ApiContent(Guid id, string name, string contentType, DateTime createDate, DateTime updateDate, ApiContentRoute route, JsonElement properties)
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