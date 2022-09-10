using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        //HTTPS Methods: Get, Post,Put ,Delete
        // Status Code: 200,201 Created,204,Bad Request 400,Unauthorised 401,402,403
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return new OkResult();

            }
            catch
            {
                return new BadRequestResult();
            }


        }

        [HttpGet("{id}")]
        public IActionResult Getone(int id)
        {
            return new OkResult();
        }

        [HttpPost]
        public IActionResult CreateOne(User user)
        {
            return new OkResult();
        }

        [HttpPut("{id}")]

        public IActionResult UpdateOne(int id, User user)
        {
            return new OkResult();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOne(int id)
        {
            return new OkResult();
        }

    }
}

