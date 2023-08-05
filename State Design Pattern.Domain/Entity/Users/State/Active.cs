using State_Design_Pattern.Domain.Entity.Users.Exceptions;

namespace State_Design_Pattern.Domain.Entity.Users.State;
public class Active : IState
{
    public void Activate(User user) => throw new AlreadyActiveException();

    public void DeActivate(User user) => user.SetState(new InActive());
}