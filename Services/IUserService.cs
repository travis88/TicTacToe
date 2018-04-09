using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Services
{
    public interface IUserService
    {
        Task<UserModel> GetUserByEmail(string email);
        Task<bool> RegisterUser(UserModel userModel);
        Task UpdateUser(UserModel user);
    }
}