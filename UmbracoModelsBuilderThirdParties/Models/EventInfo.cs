using System;

namespace UmbracoModelsBuilderThirdParties.Models
{
    public class EventInfo
    {
        public TextInfo Name { get; set; }
        public TextInfo Description { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public DateInfo Start { get; set; }
        public DateInfo End { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Changed { get; set; }
        public int Capacity { get; set; }
    }
}