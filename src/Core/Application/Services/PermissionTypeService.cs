using N5.Domain.Dtos;
using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;
using N5.Domain.Interfaces.Query;
using N5.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace N5.Application.Services
{
    public class PermissionTypeService : IPermissionTypeService
    {
        private readonly IPermissionTypeRepository _permissionTypeRepository;
        private readonly IPermissionTypeQuery _permissionTypeQuery;
        public PermissionTypeService(IPermissionTypeRepository permissionTypeRepository, IPermissionTypeQuery permissionTypeQuery)
        {
            _permissionTypeRepository = permissionTypeRepository;
            _permissionTypeQuery = permissionTypeQuery;
        }

        public async Task<PermissionTypeDto> GetAsync(int id)
        {
            PermissionTypeDto dto = null;
            var entity = await _permissionTypeQuery.GetById(id);

            if (entity != null)
            {
                dto = new PermissionTypeDto(entity);
            }

            return dto;
        }

        public async  Task<PermissionTypeDto> SaveAsync(PermissionTypeDto dto)
        {
            var item = await _permissionTypeRepository.Add(dto.ToPermissionType());
            dto.Id = item.Id;
            return dto;
        }

        public async  Task<PermissionTypeDto> UpdateAsync(PermissionTypeDto dto)
        {
            var entity = new PermissionType();
            entity.Id = dto.Id;
            entity.Name = dto.Name;
            await _permissionTypeRepository.Update(entity);
            return dto;
        }
    }
}
