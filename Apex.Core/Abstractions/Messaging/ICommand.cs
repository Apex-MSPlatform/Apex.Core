using Apex.Core.Common;
using MediatR;

namespace Apex.Core.Abstractions.Messaging
{
    public interface ICommand : IRequest<Result>
    {

    }



    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {

    }
}
