using Apex.Core.primitives;

namespace Apex.Core.Exceptions
{
    public class AlreadyExistException(ICollection<string> errors)
        : ApexException("Already Exist Exception", 409, errors)
    {

    }
}
