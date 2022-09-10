using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MEENAKSHI_FIRST_PROJECT.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {    
        public IActionResult GetAll()
        {
            var List = new List<string>();

            return new OkObjectResult(List);
        }
    }

}
