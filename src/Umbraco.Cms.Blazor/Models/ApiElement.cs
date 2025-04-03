using System.Text.Json;

namespace Umbraco.Cms.Blazor.Models;

public class ApiElement
{
    public ApiElement(Guid id, string contentType, JsonElement properties)
    {
        Id = id;
        ContentType = contentType;
        Properties = properties;
    }

    public Guid Id { get; }
    public string ContentType { get; }
    public JsonElement Properties { get; }
}
