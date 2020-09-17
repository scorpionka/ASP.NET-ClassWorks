using ClassWork16.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace ClassWork16.Controllers
{
    [RoutePrefix("api/static/languages")]
    public class LanguagesController : ApiController
    {
        LanguageContext db = new LanguageContext();

        //[Route]
        //[HttpGet]
        public ActionResult Index()
        {
            return View(db.Languages);
        }

        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult GetLanguage(int id)
        {
            if (!db.Languages.Find(id).Equals(null))
            {
                return Ok(db.Languages.Find(id));
            }
            else return NotFound();
        }

        //[HttpGet]
        //[Route("{id}/countries")]
        //public IHttpActionResult GetAllCountries(int id)
        //{
        //    if (!db.Languages.Find(id).Equals(null))
        //    {
        //        return Ok(languagePresentationService.GetCountrysLanguage(id));
        //    }
        //    return NotFound();
        //}
        //[Route]
        //[HttpPost]
        //public void CreateBook([FromBody] Book book)
        //{
        //    db.Books.Add(book);
        //    db.SaveChanges();
        //}
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
