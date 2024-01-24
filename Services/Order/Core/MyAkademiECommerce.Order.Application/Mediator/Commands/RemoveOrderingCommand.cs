using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Application.Mediator.Commands
{
    public class RemoveOrderingCommand:IRequest
    {
        public int Id { get; set; }
        public RemoveOrderingCommand(int ıd)
        {
            Id = ıd;
        }

       

    }
}
