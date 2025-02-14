using Microsoft.EntityFrameworkCore;
using User.Data;
using User.Models;

namespace UserService.Repositories
{
    public class UsersRepository: IUsersRepository
    {
        private readonly UserContext _userContext;

        public UsersRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public async Task<IEnumerable<Users>> GetAllAsync() =>
            await _userContext.Users.ToListAsync();

        public async Task<Users?> GetByIdAsync(int id) =>
            await _userContext.Users.FindAsync(id);

        public async Task AddAsync(Users user)
        {
            await _userContext.Users.AddAsync(user);
            await _userContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Users user)
        {
            _userContext.Users.Update(user);
            await _userContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _userContext.Users.FindAsync(id);
            if (user != null)
            {
                _userContext.Users.Remove(user);
                await _userContext.SaveChangesAsync();
            }
        }
    }
}
