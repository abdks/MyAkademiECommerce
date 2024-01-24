using MediatR;
using MyAkademiECommerce.Order.Application.Interfaces;
using MyAkademiECommerce.Order.Application.Mediator.Queries;
using MyAkademiECommerce.Order.Application.Mediator.Results;
using MyAkademiECommerce.Order.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Application.Mediator.Handlers
{
    public class GetOrderingByIdQueryHandler : IRequestHandler<GetOrderingByIdQuery, GetOrderingByIdQueryResult>
    {
        private readonly IRepository<Ordering> _repository;

        public GetOrderingByIdQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderingByIdQueryResult> Handle(GetOrderingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetOrderingByIdQueryResult
            {
                OrderDate = values.OrderDate,
                OrderingID = values.OrderingID,
                TotalPrice = values.TotalPrice,
                UserID = values.UserID,
            };
        }
    }

}
