using Apex.Core.primitives;

namespace Apex.Core.Exceptions
{
    public class NotFoundException : ApexException
    {
        public NotFoundException(string message) : base("Not Found Exception", 404, [message])
        {

        }


        public NotFoundException(ICollection<string> errors) : base("Not Found Exception", 404, errors)
        {

        }
    }
}
