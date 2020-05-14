using System;

namespace SwaggerRMQTutorial.Data
{
    public class Address
    {
        public short address_id { get; set; }
        public string address { get; set; }
        public string address_2 { get; set; }
        public string distinct { get; set; }
        public short city_id { get; set; }
        public int postal_code { get; set; }
        public long phone { get; set; }
        public DateTime last_update { get; set; }
    }
}
