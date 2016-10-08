using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedContentModels;
using UmbracoModelsBuilderThirdParties.Services;
using UmbracoModelsBuilderThirdParties.ViewModels;

namespace UmbracoModelsBuilderThirdParties.Controllers
{
    public class EventController : RenderMvcController
    {

        private readonly EventbriteClient eventbrite;

        public EventController()
        {
            var endpoint = ConfigurationManager.AppSettings["Eventbrite.Endpoint"];
            var apiKey = ConfigurationManager.AppSettings["Eventbrite.PersonalOAuthToken"];
            eventbrite = new EventbriteClient(endpoint, apiKey);
        }

        public async Task<ActionResult> Event(RenderModel model)
        {
            var umbEvent = new Event(model.Content);
            var eventBriteEvent = await eventbrite.GetEventAsync(umbEvent.EventbriteId);

            var vm = new EventViewModel();
            vm.UmbEvent = umbEvent;
            vm.EventbriteEvent = eventBriteEvent;
            return CurrentTemplate(vm);
        }

    }
}