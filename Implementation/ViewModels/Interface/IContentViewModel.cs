using Umbraco.Cms.Core.Models.PublishedContent;

namespace Setupper.Umbraco.Implementation.ViewModels.Interface
{
    public interface IContentViewModel<T> where T : IPublishedContent
    {
        T CurrentContent { get; set; }
    }
}
