using NpgsqlTypes;
using System;

namespace SwaggerRMQEx.Data
{
    public class Film
    {
        public short film_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int release_year { get; set; }
        public short language_id { get; set; }
        public int rental_duration { get; set; }
        public double rental_rate { get; set; }
        public int length { get; set; }
        public double replacement_cost { get; set; }
        public MpaaRating rating { get; set; }
        public DateTime last_update { get; set; }
        public string[] special_features { get; set; }
        public NpgsqlTsVector fulltext { get; set; }
    }
}
