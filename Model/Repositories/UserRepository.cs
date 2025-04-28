using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TaskTrackerApi.Model.EFCore;
using TaskTrackerApi.Model.Entities;
using TaskTrackerApi.Model.Interfaces;

namespace TaskTrackerApi.Model.Repositories;

public class UserRepository : IUserRepository
{
    private readonly TrackerTaskContext _context;

    public UserRepository(TrackerTaskContext context)
    {
        _context = context;
    }

    public Task Login(User user)
    {
        throw new NotImplementedException();
    }

    //public async Task Login(User user)
    //{
    //    bool isExists = await _context.Users.AnyAsync(u => u.Id == user.Id);

    //    if (isExists)
    //}

    public async Task Register(User user)
    {
        if (await _context.Users.AnyAsync(u => u.Username == user.Username))
            return;

        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }
}
