using TaskTrackerApi.Model.Entities;

namespace TaskTrackerApi.Model.Interfaces;

public interface IUserRepository
{
    public Task Register(User user);
    public Task Login(User user);
}
