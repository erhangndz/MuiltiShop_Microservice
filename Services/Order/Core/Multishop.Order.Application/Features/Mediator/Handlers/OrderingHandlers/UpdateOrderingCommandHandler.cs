﻿using MediatR;
using Multishop.Order.Application.Features.Mediator.Commands.OrderingCommands;
using Multishop.Order.Application.Interfaces;
using Multishop.Order.Application.MappingConfigs;
using Multishop.Order.Domain.Entities;

namespace Multishop.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class UpdateOrderingCommandHandler(IRepository<Ordering> repository) : IRequestHandler<UpdateOrderingCommand>
    {
        public async Task Handle(UpdateOrderingCommand request, CancellationToken cancellationToken)
        {
            await repository.UpdateAsync(ObjectMapper.Mapper.Map<Ordering>(request));
        }
    }
}
