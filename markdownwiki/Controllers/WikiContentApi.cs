using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace markdownwiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WikiContentApi : ControllerBase
    {
        [HttpGet("[action]")]
        public string GetPageMarkdown(string path)
        {
            // input validation
            // authentication?
            // private api's only available for app?

            var content = "";

            try
            {
                using (var streamreader = new StreamReader(path + ".md"))
                {
                    content = streamreader.ReadToEnd();

                }
            }
            catch (FileNotFoundException ex)
            {
                return ex.Message;
            }
            
            return content;
        }
    }
}
