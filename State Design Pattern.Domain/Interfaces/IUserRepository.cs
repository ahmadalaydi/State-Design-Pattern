using State_Design_Pattern.Domain.Entity.Users;

namespace State_Design_Pattern.Domain.Interfaces;
public interface IUserRepository
{
    User GetById(int id);
    List<User> GetAll();
}