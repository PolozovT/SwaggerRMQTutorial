using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("category", Schema = "public")]
    public class CategoryEntity
    {
        [Key, Column("category_id")]
        public short CategoryId { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
        
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
