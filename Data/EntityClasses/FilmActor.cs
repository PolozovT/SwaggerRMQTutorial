using System;

namespace SwaggerRMQEx.Data
{
    public class FilmActor
    {
        public short actor_id { get; set; }
        public short film_id { get; set; }
        public DateTime last_update { get; set; }
    }
}
