using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Item.Update
{
    public class UpdateItemRequest : IRequest<Response<UpdateItemResult>>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ItemDto ToItemDto()
        {
            return new ItemDto()
            {
                Title = this.Title,
                Description = this.Description,
                Id = this.Id
            };
        }
    }
}
