using System;

namespace SwaggerRMQEx.Data
{
    public class Customer
    {
        public short customer_id { get; set; }
        public short store_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public short address_id { get; set; }
        public bool activebool { get; set; }
        public DateTime create_date { get; set; }
        public DateTime last_update { get; set; }
        public short active { get; set; }
    }
}
