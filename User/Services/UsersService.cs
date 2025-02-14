using User.Models;
using UserService.Repositories;

namespace UserService.Services
{
    public class UsersService: IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task AddAsync(Users user) =>
            await _usersRepository.AddAsync(user);

        public async Task DeleteAsync(int id) =>
            await _usersRepository.DeleteAsync(id);

        public async Task<IEnumerable<Users>> GetAllUsersAsync() =>
            await _usersRepository.GetAllAsync();

        public async Task<Users?> GetByIdAsync(int id) =>
            await _usersRepository.GetByIdAsync(id);

        public async Task UpdateAsync(Users user) =>
            await _usersRepository.UpdateAsync(user);
    }
}
