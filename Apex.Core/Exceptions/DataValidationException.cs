using Apex.Core.primitives;

namespace Apex.Core.Exceptions
{
    public class DataValidationException(List<string> errors) : ApexException("ValidationException", 400, errors)
    {

    }
}