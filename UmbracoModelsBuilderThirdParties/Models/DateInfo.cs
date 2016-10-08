using System;

namespace UmbracoModelsBuilderThirdParties.Models
{
    public class DateInfo
    {
        public string Timezone { get; set; }
        public DateTime Local { get; set; }
        public DateTimeOffset Utc { get; set; }
    }
}