using System;

namespace SwaggerRMQTutorial.Data
{
    public class Staff
    {
        public short staff_id { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public short address_id { get; set; }
        public string email { get; set; }
        public short store_id { get; set; }
        public bool active { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime last_update { get; set; }
        public string picture { get; set; } // type ?
    }
}
