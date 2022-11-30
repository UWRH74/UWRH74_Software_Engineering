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
    }
}
