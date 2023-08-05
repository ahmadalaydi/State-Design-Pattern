using System.Runtime.Serialization;

namespace State_Design_Pattern.Domain.Entity.Users.Exceptions;
[Serializable]
public class AlreadyActiveException : Exception
{
    public AlreadyActiveException()
    { }

    public AlreadyActiveException(string? message) : base(message)
    {
    }

    public AlreadyActiveException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected AlreadyActiveException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}