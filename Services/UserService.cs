using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Services
{
    public class UserService : IUserService
    {
        private static ConcurrentBag<UserModel> _userStore;

        public UserService()
        {
            _userStore = new ConcurrentBag<UserModel>();
        }

        public Task<UserModel> GetUserByEmail(string email) =>
            Task.FromResult(_userStore.FirstOrDefault(u => u.Email == email));

        public Task<bool> RegisterUser(UserModel userModel) =>
            Task.FromResult(true);

        public Task UpdateUser(UserModel user)
        {
            _userStore = new ConcurrentBag<UserModel>(_userStore.Where(u => u.Email != user.Email))
            {
                user
            };
            return Task.CompletedTask;
        }
    }
}