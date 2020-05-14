using System;

namespace SwaggerRMQTutorial.Data
{
    public class Actor
    {
        public short actor_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime last_update { get; set; }
    }
}
