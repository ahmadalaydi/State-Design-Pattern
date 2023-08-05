using State_Design_Pattern.Domain.Entity.Users.Converter;
using System.Text.Json.Serialization;

namespace State_Design_Pattern.Domain.Entity.Users.State;

[JsonConverter(typeof(UserStateConverter))]
public interface IState
{
    void Activate(User user);
    void DeActivate(User user);
}