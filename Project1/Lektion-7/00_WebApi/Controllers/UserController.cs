using _00_WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _00_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //Http: Get,Put, Post, Delete
        [HttpGet]
        public IActionResult GetAll()
        {
            return new OkResult();
        }

        [HttpGet("{id}")]

        public IActionResult GetOne(int id)
        {
            return new OkResult();
        }

        [HttpPost]

        public IActionResult CreateOne(UserRequest userRequest)
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
