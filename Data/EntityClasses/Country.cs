using System;

namespace SwaggerRMQEx.Data
{
    public class Country
    {
        public short country_id { get; set; }
        public string country { get; set; }
        public DateTime last_update { get; set; }
    }
}
