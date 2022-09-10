using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    public class User_Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UsersController : ControllerBase
        {
            private List<User> _users = new List<User>();


            [HttpGet]
            public IActionResult GetAll()
            {
                return new OkObjectResult(_users);
            }

            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var _user = _users.FirstOrDefault(x => x.Id == id);
                if (_user != null)
                    return new OkObjectResult(_user);

                return new NotFoundResult();
            }

            [HttpPost]
            public IActionResult Create(User user)
            {
                try
                {
                    _users.Add(user);
                    return new CreatedResult("https://localhost/", user);
                }
                catch
                {
                    return new BadRequestResult();
                }

            }


            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                try
                {
                    if (!_users.Any(x => x.Id == id))
                    {
                        return new NotFoundResult();
                    }

                    _users = _users.Where(x => x.Id != id).ToList();
                    return new OkResult();
                }
                catch
                {
                    return new BadRequestResult();
                }

            }

        }
    }
}


