using Microsoft.AspNetCore.Mvc;
using webapi.services.UserTypesService;
using webapi.ViewModels;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserTypesController : Controller
    {
        private readonly IUserTypesService _userTypesService;

        public UserTypesController(IUserTypesService userTypesService)
        {
            _userTypesService = userTypesService;
        }

        [HttpPost(nameof(add))]
        public IActionResult add(UserTypesVM userTypesVM)
        {
            return Ok(_userTypesService.addUserTypes(userTypesVM));
        }
    }
}
