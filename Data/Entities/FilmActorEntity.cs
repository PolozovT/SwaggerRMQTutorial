using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("film_actor", Schema = "public")]
    public class FilmActorEntity
    {
        [Key, Column("actor_id")]
        public short ActorId { get; set; }

        [Column("film_id")]
        public short FilmId { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
