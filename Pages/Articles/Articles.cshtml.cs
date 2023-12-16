using Articles.API;
using Articles.Models.ArticleModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;

namespace Articles.Pages.Articles
{
    public class ArticlesModel : PageModel
    {
        public News? News { get; private set; }

        const string newsDataUrl = "https://newsdata.io/api/1/news";
        const string newsDataAPIKey = "pub_348597372904dd0f1e04752af44c8328101c4";
        public async Task OnGetAsync(string theme, List<Language> languages)
        {
            // If no specific language is selected, default to English
            if (languages == null || !languages.Any())
            {
                languages = new List<Language> { Language.En };
            }

            APIRequest api = new APINewsData(newsDataUrl, newsDataAPIKey, theme, languages);
            ResponseBody response = new(api);
            News = await response.GetResponseBodyAsTAsync<News>();
        }
    }
}
