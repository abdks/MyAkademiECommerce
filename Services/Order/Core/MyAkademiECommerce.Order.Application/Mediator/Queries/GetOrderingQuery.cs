using MediatR;
using MyAkademiECommerce.Order.Application.Features.CQRS.Results;
using MyAkademiECommerce.Order.Application.Mediator.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Application.Mediator.Queries
{
    public class GetOrderingQuery : IRequest<List<GetOrderingQueryResult>>
    {
        // Query parametreleri, constructor, vb. eklenebilir.
    }
}
