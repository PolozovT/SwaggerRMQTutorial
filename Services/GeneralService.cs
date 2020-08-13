using Microsoft.EntityFrameworkCore;
using System;

namespace SwaggerRMQTutorial.Data
{
    public abstract class GeneralService<T>
    {
        private protected PostgreConnector _db = new PostgreConnector(new DbContextOptions<PostgreConnector>());

        public string Name { get; private set; }

        protected GeneralService(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

    }
}
