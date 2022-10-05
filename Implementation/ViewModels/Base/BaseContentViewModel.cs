using Setupper.Umbraco.Implementation.ViewModels.Interface;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Setupper.Umbraco.Implementation.ViewModels.Base
{
    public class BaseContentViewModel<T> : IContentViewModel<T> where T : IPublishedContent
    {
        public T CurrentContent { get; set; }

        public BaseContentViewModel(T currentContent)
        {
            CurrentContent = currentContent;
        }
    }
}
