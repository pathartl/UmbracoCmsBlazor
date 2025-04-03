using Microsoft.AspNetCore.Components;
using Umbraco.Cms.Blazor.Models;

namespace Umbraco.Cms.Blazor.Components;

public interface IModelComponentBase : IComponent
{
    public Guid Id { get; set; }
    public string ContentType { get; set; }
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public ApiContentRoute Route { get; set; }
}