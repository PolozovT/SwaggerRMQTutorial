using System;
using System.Collections.Generic;

namespace SwaggerRMQTutorial
{
    public partial class Language
    {
        public Language()
        {
            Film = new HashSet<Film>();
        }

        public short LanguageId { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<Film> Film { get; set; }
    }
}
