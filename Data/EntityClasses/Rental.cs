using System;

namespace SwaggerRMQEx.Data
{
    public class Rental
    {
        public int rental_id { get; set; }
        public DateTime rental_date { get; set; }
        public short investory_id { get; set; }
        public short customer_id { get; set; }
        public DateTime return_date { get; set; }
        public int staff_id { get; set; }
        public DateTime last_update { get; set; }
    }
}
