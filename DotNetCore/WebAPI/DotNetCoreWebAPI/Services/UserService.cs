using DotNetCoreWebAPI.Models;
using DotNetCoreWebAPI.Repositories;

namespace DotNetCoreWebAPI.Services
{
    public interface IUserService
    {
        public Task<UserModel> Authenticate(string username, string password);
        public List<UserModel> GetAllUsers();
    }
    public class UserService : IUserService
    {
        private readonly DotNetCoreWebAPIDBContext _context;
        public UserService(DotNetCoreWebAPIDBContext context)
        {
            _context = context;
        }
        public Task<UserModel> Authenticate(string username, string password)
        {
            var user = _context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);
            if (user == null)
                return Task.FromResult<UserModel>(null);
            return Task.FromResult(user);
        }
        public List<UserModel> GetAllUsers()
        {
            // Anonymous type object 
            var anony_object = new
            {
                s_id = 134,
                s_name = "Siya",
                language = "Ruby"
            };
            return _context.Users.ToList();
        }

        public (int, string) GetUserDetails()
        {
            var user = _context.Users.FirstOrDefault();
            if (user != null)
            {
                return (user.Id, user.Username);
            }
            return (0, string.Empty);
        }
    }
   
    
}
