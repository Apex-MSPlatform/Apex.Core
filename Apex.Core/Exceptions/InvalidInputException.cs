using Apex.Core.primitives;

namespace Apex.Core.Exceptions
{
    public class InvalidInputException : ApexException
    {
        public InvalidInputException(string id, string message = "is invalid")
            : base($"{id} {message}", 400)
        {
        }
    }
}