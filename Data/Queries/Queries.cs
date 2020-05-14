namespace SwaggerRMQTutorial.Data
{
    public class Queries
    {
        public const string allCities = "SELECT * FROM city";

        public const string allActors = "SELECT * FROM actor";

        public const string allCountries = "SELECT * FROM country";

        public const string allFilms = "SELECT * FROM film";

        public const string allLanguages = "SELECT * FROM language";

        public const string allInvestors = "SELECT * FROM investory";

        public static string englishFilms = $" SELECT * FROM film WHERE language_id = {(int)LanguageEnum.English}";

        public const string englishId = " SELECT * FROM language WHERE name = 'English'";

        public const string russianCities = "SELECT * FROM city WHEREcountry_id = 80";

        public static string actorsWithLastName(string lastName) => $"select * from actor where last_name = '{lastName}';";
    }
}
