using MediatR;
using MyAkademiECommerce.Order.Application.Interfaces;
using MyAkademiECommerce.Order.Application.Mediator.Commands;
using MyAkademiECommerce.Order.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Application.Mediator.Handlers
{
    public class CreateOrderingCommandHandler : IRequestHandler<CreateOrderingCommend>
    {
        private readonly IRepository<Ordering> _repository;

        public CreateOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateOrderingCommend request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Ordering
            {
                OrderDate = request.OrderDate,
                TotalPrice = request.TotalPrice,
                UserID  = request.UserID,
            });
            }
        }

    }
 
