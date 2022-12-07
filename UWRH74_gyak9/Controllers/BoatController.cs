using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UWRH74_gyak9.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]
        public IActionResult MindegyHogyHivjak()
        {
            Models.HajosContext context = new();
            var kérdések = from x in context.Questions select x.Question1;

            return Ok(kérdések);
        }

        [HttpGet]
        [Route("questions/{sorszám}")]
        public ActionResult M2(int sorszám)
        {
            Models.HajosContext context = new Models.HajosContext();
            var kérdés = (from x in context.Questions
                          where x.QuestionId == sorszám
                          select x).FirstOrDefault();

            if (kérdés == null) return BadRequest("Nincs ilyen sorszámú kérdés");

            return new JsonResult(kérdés);
        }

        [HttpGet]
        [Route("questions/count")]
        public int M4() //Tetszőleges metódusnév
        {
            Models.HajosContext context = new();
            int kérdésekSzáma = context.Questions.Count();

            return kérdésekSzáma;
        }

    }
}
