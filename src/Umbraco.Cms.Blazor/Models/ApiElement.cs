using System.Text.Json;

namespace Umbraco.Cms.Blazor.Models;

public class ApiElement<TPublishedElement>
{
    public ApiElement(Guid id, string contentType, TPublishedElement properties)
    {
        Id = id;
        ContentType = contentType;
        Properties = properties;
    }

    public Guid Id { get; }
    public string ContentType { get; }
    public TPublishedElement Properties { get; }
}
