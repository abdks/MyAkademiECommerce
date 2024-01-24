using MediatR;
using MyAkademiECommerce.Order.Application.Interfaces;
using MyAkademiECommerce.Order.Application.Mediator.Queries;
using MyAkademiECommerce.Order.Application.Mediator.Results;
using MyAkademiECommerce.Order.Domain.Entites;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Application.Mediator.Handlers
{
    public class GetOrderingQueryHandler : IRequestHandler<GetOrderingQuery, List<GetOrderingQueryResult>>
    {
        private readonly IRepository<Ordering> _repository;

        public GetOrderingQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetOrderingQueryResult>> Handle(GetOrderingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetOrderingQueryResult
            {
                OrderDate = x.OrderDate,
                OrderingID = x.OrderingID,
                TotalPrice = x.TotalPrice,
                UserID = x.UserID
            }).ToList();
        }
    }
}
