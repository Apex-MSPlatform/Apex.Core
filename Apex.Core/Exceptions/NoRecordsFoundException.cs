using Apex.Core.primitives;

namespace Apex.Core.Exceptions
{
    public class NoRecordsFoundException : ApexException
    {
        public NoRecordsFoundException(string entityName) : base($"No {entityName} records found.", 404)
        {

        }
    }
}