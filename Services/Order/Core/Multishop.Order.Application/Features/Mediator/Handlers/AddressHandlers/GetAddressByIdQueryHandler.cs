﻿using MediatR;
using Multishop.Order.Application.Features.Mediator.Queries.AddressQueries;
using Multishop.Order.Application.Features.Mediator.Results.AddressResults;
using Multishop.Order.Application.Interfaces;
using Multishop.Order.Application.MappingConfigs;
using Multishop.Order.Domain.Entities;

namespace Multishop.Order.Application.Features.Mediator.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler(IRepository<Address> repository) : IRequestHandler<GetAddressByIdQuery, GetAddressByIdQueryResult>
    {
        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
        {

            return ObjectMapper.Mapper.Map<GetAddressByIdQueryResult>(await repository.GetByIdAsync(request.Id));
        }
    }
}
