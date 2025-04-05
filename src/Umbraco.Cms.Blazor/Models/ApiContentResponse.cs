using System.Text.Json;
using System.Text.Json.Serialization;
namespace Umbraco.Cms.Blazor.Models;

public class ApiContentResponse<TPublishedElement> : ApiContent<TPublishedElement>
{
    [JsonConstructor]
    public ApiContentResponse(Guid id, string name, string contentType, DateTime createDate, DateTime updateDate, ApiContentRoute route, TPublishedElement properties, IDictionary<string, ApiContentRoute> cultures)
        : base(id, name, contentType, createDate, updateDate, route, properties)
        => Cultures = cultures;
    
    public IDictionary<string, ApiContentRoute> Cultures { get; }
}