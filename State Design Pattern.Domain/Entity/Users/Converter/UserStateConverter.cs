using State_Design_Pattern.Domain.Entity.Users.State;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace State_Design_Pattern.Domain.Entity.Users.Converter;

public class UserStateConverter : JsonConverter<IState>
{
    public override IState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    => GetUserState(reader.GetString()!);

    public override void Write(Utf8JsonWriter writer, IState value, JsonSerializerOptions options)
    => writer.WriteStringValue(value.GetType().Name);

    private static IState GetUserState(string state)
    => state switch
    {
        nameof(Active) => new Active(),
        nameof(InActive) => new InActive(),
        _ => throw new NotImplementedException(),
    };
}
