using System.Reflection;
using Microsoft.AspNetCore.Components;
using Umbraco.Cms.Blazor.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Umbraco.Cms.Blazor.Components
{
    public class ModelComponentBase<TPublishedElement> : ComponentBase, IModelComponentBase
        where TPublishedElement : IPublishedElement
    {
        [Parameter]
        public TPublishedElement Model { get; set; }
        [Parameter]
        public Guid Id { get; set; }
        [Parameter]
        public string ContentType { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public DateTime CreateDate { get; set; }
        [Parameter]
        public DateTime UpdateDate { get; set; }
        [Parameter]
        public ApiContentRoute Route { get; set; }
    }
}
