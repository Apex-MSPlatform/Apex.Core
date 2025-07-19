using Apex.Core.Common;
using MediatR;

namespace Apex.Core.Abstractions.Messaging
{
    public interface IQuery : IRequest<Result>
    {

    }

    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {

    }
}
