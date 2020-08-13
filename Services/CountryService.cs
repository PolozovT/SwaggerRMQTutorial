using SwaggerRMQTutorial.Interfaces;

namespace SwaggerRMQTutorial.Data
{
    public class CountryService : GeneralService<Country>, ICountryService
    {
        public CountryService() : base("Country")
        { }

    }
}
