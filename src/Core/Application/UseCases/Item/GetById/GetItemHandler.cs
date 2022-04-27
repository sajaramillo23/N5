using MediatR;
using N5.Application.Exceptions;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.Item.GetById
{
    public class GetItemHandler : IRequestHandler<GetItemRequest, Response<GetItemResult>>
    {
        private readonly IItemService _itemService;

        public GetItemHandler(IItemService itemService)
        {
            _itemService = itemService;
        }
        public async Task<Response<GetItemResult>> Handle(GetItemRequest request, CancellationToken cancellationToken)
        {
            var item = await _itemService.GetItemAsync(request.Id);

            if (item is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            var itemResult = new GetItemResult(item);

            return new Response<GetItemResult>(itemResult);
        }
    }
}
