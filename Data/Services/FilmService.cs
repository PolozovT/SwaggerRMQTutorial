using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerRMQEx.Data
{
    public class FilmService : GeneralService<Film>
    {
        public FilmService() : base("Film")
        { }

        public async Task<int> GetCountEnglishFilms()
        {
            return await _db.FilmList.Where(x => x.LanguageId == (int)LanguageEnum.English).CountAsync();
        }
    }
}
