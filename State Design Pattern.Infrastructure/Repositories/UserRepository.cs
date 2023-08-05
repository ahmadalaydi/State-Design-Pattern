using State_Design_Pattern.Domain.Entity.Users;
using State_Design_Pattern.Domain.Entity.Users.State;
using State_Design_Pattern.Domain.Interfaces;

namespace State_Design_Pattern.Infrastructure.Repositories;
internal class UserRepository : IUserRepository
{
    private readonly List<User> _users;

    public UserRepository()
    => _users = new List<User>
        {
            new User(1,"Emma",new Active()),
            new User(2,"Liam",new InActive()),
            new User(3,"Olivia ",new Active())
        };

    public List<User> GetAll() => _users;

    public User GetById(int id)
    => _users.FirstOrDefault(u => u.Id == id)!;

}