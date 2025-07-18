﻿using Apex.Core.Common;
using MediatR;

namespace Apex.Core.Abstractions.Messaging
{
    public interface IQueryHandler<TQuery> : IRequestHandler<TQuery, Result>
        where TQuery : IQuery
    {

    }

    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
        where TQuery : IQuery<TResponse>
    {

    }
}
