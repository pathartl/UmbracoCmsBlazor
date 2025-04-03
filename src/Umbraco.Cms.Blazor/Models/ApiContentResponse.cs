using System.Text.Json;
using System.Text.Json.Serialization;
namespace Umbraco.Cms.Blazor.Models;

public class ApiContentResponse : ApiContent
{
    [JsonConstructor]
    public ApiContentResponse(Guid id, string name, string contentType, DateTime createDate, DateTime updateDate, ApiContentRoute route, JsonElement properties, IDictionary<string, ApiContentRoute> cultures)
        : base(id, name, contentType, createDate, updateDate, route, properties)
        => Cultures = cultures;
    
    public IDictionary<string, ApiContentRoute> Cultures { get; }
}