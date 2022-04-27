using MediatR;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.Item.Save
{
    public class SaveItemHandler : IRequestHandler<SaveItemRequest, Response<SaveItemResult>>
    {
        private readonly IItemService _itemService;

        public SaveItemHandler(IItemService itemService)
        {
            _itemService = itemService;
        }
        public async Task<Response<SaveItemResult>> Handle(SaveItemRequest request, CancellationToken cancellationToken)
        {
           var item = await _itemService.SaveItemAsync(request.ToItemDto());

            var itemResult = new SaveItemResult(item);

            return new Response<SaveItemResult>(itemResult);
        }
    }
}
