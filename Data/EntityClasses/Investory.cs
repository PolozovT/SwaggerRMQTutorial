using System;

namespace SwaggerRMQEx.Data
{
    public class Investory
    {
        public short investory_id { get; set; }
        public short film_id { get; set; }
        public short store_id { get; set; }
        public DateTime last_update { get; set; }
    }
}
