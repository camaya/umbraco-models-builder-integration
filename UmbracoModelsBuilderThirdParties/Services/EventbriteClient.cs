using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UmbracoModelsBuilderThirdParties.Models;

namespace UmbracoModelsBuilderThirdParties.Services
{
    public class EventbriteClient
    {

        private static HttpClient client = new HttpClient();
        private readonly string endpoint;
        private readonly string apiKey;

        public EventbriteClient(string endpoint, string apiKey)
        {
            this.endpoint = endpoint;
            this.apiKey = apiKey;
        }

        public async Task<EventInfo> GetEventAsync(string id)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri($"{endpoint}events/{id}/"),
                Method = HttpMethod.Get
            };
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            EventInfo eventInfo = null;
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                eventInfo = await response.Content.ReadAsAsync<EventInfo>();
            }
            return eventInfo;
        }

    }
}