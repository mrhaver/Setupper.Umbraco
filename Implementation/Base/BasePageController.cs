using Microsoft.AspNetCore.Mvc;
using Setupper.Umbraco.Implementation.ViewModels.Base;
using Setupper.Umbraco.Implementation.ViewModels.Interface;
using Setupper.Umbraco.Services.Interface;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.Controllers;

namespace Setupper.Umbraco.Implementation.Base
{
    public abstract class BasePageController<T> : RenderController where T : class, IPublishedContent
    {
        protected IContentViewModel<T> ViewModel = null!;

        protected BasePageController(
            IBaseControllerFacade facade)
            : base(facade.GetRenderControllerLogger(), facade.GetCompositeViewEngine(), facade.GetUmbracoContextAccessor())
        {
        }

        public override IActionResult Index()
        {
            if (CurrentPage is not T currentPage)
                throw new InvalidOperationException();

            ViewModel = new BaseContentViewModel<T>(currentPage);

            return TypedIndex(currentPage);
        }

        public abstract IActionResult TypedIndex(T currentModel);
    }
}
