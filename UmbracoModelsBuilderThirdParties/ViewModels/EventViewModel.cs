using Umbraco.Web.Models;
using Umbraco.Web.PublishedContentModels;
using UmbracoModelsBuilderThirdParties.Models;
using Umbraco.Web;

namespace UmbracoModelsBuilderThirdParties.ViewModels
{
    public class EventViewModel : RenderModel
    {
        public EventViewModel() : base(UmbracoContext.Current.PublishedContentRequest.PublishedContent) { }

        public Event UmbEvent { get; set; }
        public EventInfo EventbriteEvent { get; set; }
    }
}