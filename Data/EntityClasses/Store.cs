using System;

namespace SwaggerRMQTutorial.Data
{
    public class Store
    {
        public short store_id { get; set; }
        public short manager_stuff_id { get; set; }
        public short address_id { get; set; }
        public DateTime last_update { get; set; }
    }
}
