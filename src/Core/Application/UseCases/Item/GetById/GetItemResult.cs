using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Item.GetById
{
    public class GetItemResult 
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public GetItemResult(ItemDto itemDto)
        {
            Id = itemDto.Id;
            Title = itemDto.Title;
            Description = itemDto.Description;
        }
    }
}
