using System.Threading.Tasks;
using OneSalonManager.API.Models;

namespace OneSalonManager.API.Data
{
    public interface IAuthRepository
    {
         Task<User> RegisterUser(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}