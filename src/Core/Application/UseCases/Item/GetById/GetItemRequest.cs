using MediatR;
using N5.Common.Helpers;
using System;

namespace N5.Application.UseCases.Item.GetById
{
    public class GetItemRequest : IRequest<Response<GetItemResult>>
    {
        public Guid Id { get; set; }

        public GetItemRequest(Guid itemId) 
        {
            Id = itemId;
        }
    }
}
