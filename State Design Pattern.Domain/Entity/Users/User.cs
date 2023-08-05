using State_Design_Pattern.Domain.Entity.Users.State;

namespace State_Design_Pattern.Domain.Entity.Users;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IState State { get; private set; }
    public User(int id,string name,IState state) => (Id,Name,State) = (id,name,state);
    public void Activate() => State.Activate(this);
    public void DeActivate() => State.DeActivate(this);
    protected internal void SetState(IState state) => State = state;
}