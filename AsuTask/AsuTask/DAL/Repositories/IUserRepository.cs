using AsuTask.DAL.Enitites;
using AsuTask.Repository.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AsuTask.DAL.Repositories
{
    public interface IUserRepository
    {
        Task<User> FindUserByLoginAndPasswordAsync(string login, string password); 
    }

    internal class UserRepository : IUserRepository
    {
        private readonly AsuTestContext _context;

        public UserRepository(AsuTestContext context)
        {
            _context = context;
        }

        public async Task<User> FindUserByLoginAndPasswordAsync(string login, string password)
        {
            return await _context.Set<User>()
                .SingleOrDefaultAsync(u => u.Login == login && u.Password == password);
        }
    }
}
