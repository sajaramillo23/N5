using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;

namespace N5.Application.UseCases.Item.Save
{
    public class SaveItemRequest : IRequest<Response<SaveItemResult>>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public ItemDto ToItemDto() 
        {
            return new ItemDto()
            {
                Title = this.Title,
                Description = this.Description
            };       
        }
    }
}
