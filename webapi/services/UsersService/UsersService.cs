using webapi.Data;
using webapi.Models;
using webapi.ViewModels;
namespace webapi.services.UsersService 
{

    public class UsersService : IUsersService
    {
        private readonly dbContext _context;
        public UsersService(dbContext context)
        {
            _context = context;
        }
        public Users addUsers(UsersVM usersVM)
        {
            Users newUsers = new Users()
            {
                id = Guid.NewGuid(),
                name = usersVM.name,
                email = usersVM.email,
                password = usersVM.password,
                remember_token = usersVM.remember_token,
                user_type_id = usersVM.user_type_id
        
             };
            _context.users.Add(newUsers);
            _context.SaveChanges();
            return newUsers;
        }
        public Users editUser(Guid userId, UsersVM usersVM)
        {
            Users existingUser = _context.users.FirstOrDefault(u => u.id == userId);

            if (existingUser != null)
            {
                existingUser.name = usersVM.name;
                existingUser.email = usersVM.email;
                existingUser.password = usersVM.password;
                existingUser.remember_token = usersVM.remember_token;
                existingUser.user_type_id = usersVM.user_type_id;

                _context.SaveChanges();
            }

            return existingUser;
        }
    }
}