using System.Runtime.Serialization;

namespace State_Design_Pattern.Domain.Entity.Users.Exceptions;
[Serializable]
public class AlreadyInActiveException : Exception
{
    public AlreadyInActiveException()
    {
    }

    public AlreadyInActiveException(string? message) : base(message)
    {
    }

    public AlreadyInActiveException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected AlreadyInActiveException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
