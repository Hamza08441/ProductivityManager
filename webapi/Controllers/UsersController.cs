using Microsoft.AspNetCore.Mvc;
using webapi.services.UsersService;
using webapi.ViewModels;
namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersService _UsersService;
        public UsersController(IUsersService usersService) {
        _UsersService = usersService;
        }

        [HttpPost(nameof(add))]
        public IActionResult add(UsersVM users)
        {
            return Ok(_UsersService.addUsers(users));
        }

        [HttpPut(nameof(edit))]
        public IActionResult edit(Guid id, UsersVM users)
        {
            return Ok(_UsersService.editUser(id, users));
        }
    }
}
