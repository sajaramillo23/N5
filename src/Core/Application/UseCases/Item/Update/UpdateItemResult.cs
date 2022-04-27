using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Item.Update
{
    public class UpdateItemResult
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public UpdateItemResult(ItemDto itemDto)
        {
            Id = itemDto.Id;
            Title = itemDto.Title;
            Description = itemDto.Description;
        }
    }
}
