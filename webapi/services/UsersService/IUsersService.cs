using webapi.Models;
using webapi.ViewModels;

namespace webapi.services.UsersService
{
    public interface IUsersService {
        public Users addUsers(UsersVM usersVM);
        public Users editUser(Guid userId, UsersVM usersVM);
    }
}