using webapi.Models;
using webapi.ViewModels;

namespace webapi.services.UserTypesService
{
    public interface IUserTypesService
    {
        public UserTypes addUserTypes(UserTypesVM userTypesVM);
    }
}