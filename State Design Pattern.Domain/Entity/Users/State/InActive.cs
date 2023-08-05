using State_Design_Pattern.Domain.Entity.Users.Exceptions;

namespace State_Design_Pattern.Domain.Entity.Users.State;
public class InActive : IState
{
    public void Activate(User user) => user.SetState(new InActive());

    public void DeActivate(User user) => throw new AlreadyInActiveException();
}