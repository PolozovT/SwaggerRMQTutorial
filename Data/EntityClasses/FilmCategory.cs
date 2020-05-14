using System;

namespace SwaggerRMQTutorial.Data
{
    public class FilmCategory
    {
        public short film_id { get; set; }
        public short category_id { get; set; }
        public DateTime last_update { get; set; }
    }
}
