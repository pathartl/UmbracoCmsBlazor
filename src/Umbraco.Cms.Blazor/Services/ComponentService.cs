using System.ComponentModel;
using System.Reflection;
using Umbraco.Cms.Blazor.Components;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace Umbraco.Cms.Blazor.Services;

public class ComponentService
{
   // This service should provide methods to map a string contentType from Umbraco to a Blazor component.
   // It should have an initialization (probably can happen in the constructor) that will build a
   // Dictionary<string, ModelComponentBase> to store in memory. This way it doesn't have to use reflection
   // every time it needs to get the new component. Then, inside ContentItem we can a parameter for the
   // componentType name and namespace prefix for where the components should live. I don't know what else
   // we might have to do for casting purposes and contentItems.
   private readonly Dictionary<string, Type> _components = new();
   private readonly Dictionary<string, Type> _models = new();

   public ComponentService()
   {
      var publishedElementTypes = AppDomain
         .CurrentDomain
         .GetAssemblies()
         .SelectMany(a => a.GetTypes())
         .Where(t => t.Implements<IPublishedElement>())
         .ToList();

      var modelComponentTypes = AppDomain
         .CurrentDomain
         .GetAssemblies()
         .SelectMany(a => a.GetTypes())
         .Where(t => t.Implements<IModelComponentBase>())
         .ToList();

      foreach (var publishedElementType in publishedElementTypes)
      {
         var contentType = publishedElementType.GetCustomAttribute<PublishedModelAttribute>()?.ContentTypeAlias ?? string.Empty;
         var componentType = modelComponentTypes.FirstOrDefault(t => t.BaseType != null &&
            t.BaseType.IsGenericType && t.BaseType.GenericTypeArguments.Contains(publishedElementType));

         if (!String.IsNullOrEmpty(contentType) && !_components.ContainsKey(contentType) && componentType != null)
         {
            _components[contentType] = componentType;
            _models[contentType] = publishedElementType;
         }
      }
   }

   public Type GetComponentType(string contentType)
   {
      return _components.GetValueOrDefault(contentType);
   }

   public Type GetModelType(string contentType)
   {
      return _models.GetValueOrDefault(contentType);
   }
}