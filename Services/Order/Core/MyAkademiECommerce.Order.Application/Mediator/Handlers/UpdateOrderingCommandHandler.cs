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
    public class UpdateOrderingCommandHandler : IRequestHandler<UpdateOrderingCommand>
    {
        private readonly IRepository<Ordering> _repository;

        public UpdateOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateOrderingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.OrderingID);
            values.OrderDate = request.OrderDate;
            values.UserID = request.UserID;
            values.TotalPrice = request.TotalPrice;
            await _repository.UpdateAsync(values);
         
        }
    }
}
