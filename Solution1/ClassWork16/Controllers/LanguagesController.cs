using ClassWork16.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ClassWork16.Controllers
{
    [RoutePrefix("api/static/languages")]
    public class LanguagesController : ApiController
    {
        [Route]
        [HttpGet]
        // GET api/static/languages
        public IEnumerable<string> Get(List<Language> languages)
        {
            string[] languages = new string[]();

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
