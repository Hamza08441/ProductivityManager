using webapi.Data;
using webapi.Models;
using webapi.services.UserTypesService;
using webapi.ViewModels;

namespace webapi.services.UserTypesServices
{
    public class UserTypesService : IUserTypesService
    {
        private readonly dbContext _context;

        public UserTypesService(dbContext context)
        {

            _context = context;
        }
        public UserTypes addUserTypes(UserTypesVM userTypesVM)
        {

            UserTypes newUserType = new UserTypes()
            {
                id = Guid.NewGuid(),
                name = userTypesVM.name,
                access_level = userTypesVM.access_level,
            };

            _context.userTypes.Add(newUserType);
            _context.SaveChanges();
            return newUserType;
        }
    }
}