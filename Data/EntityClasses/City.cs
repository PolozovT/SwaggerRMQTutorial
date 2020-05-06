using System;

namespace SwaggerRMQEx.Data
{
    public class City
    {
        public short city_id { get; set; }
        public string city { get; set; }
        public short country_id { get; set; }
        public DateTime last_update { get; set; }
    }

}