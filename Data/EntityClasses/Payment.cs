using System;

namespace SwaggerRMQTutorial.Data
{
    public class Payment
    {
        public short payment_id { get; set; }
        public int customer_id { get; set; }
        public short staff_id { get; set; }
        public short rental_id { get; set; }
        public double amount { get; set; }
        public DateTime payment_date { get; set; }
    }
}
