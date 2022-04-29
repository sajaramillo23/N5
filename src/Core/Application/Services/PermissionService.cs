using N5.Domain.Dtos;
using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;
using N5.Domain.Interfaces.Query;
using N5.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace N5.Application.Services
{
    public  class PermissionService:IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IPermissionQuery _permissionQuery;
        public PermissionService(IPermissionRepository employeeRepository, IPermissionQuery permissionQuery)
        {
            _permissionRepository = employeeRepository;
            _permissionQuery = permissionQuery;
        }
        public async Task<PermissionDto> SaveAsync(PermissionDto dto)
        {
            var entity = await _permissionRepository.Add(dto.ToPermission());

            dto.Id = entity.Id;

            return dto;
        }

        public async Task<PermissionDto> GetAsync(int id)
        {
            PermissionDto dto = null;
            var entity = await _permissionQuery.GetById(id);

            if (entity != null)
            {
                dto = new PermissionDto(entity);
            }

            return dto;
        }


        public async Task<PermissionDto> UpdateAsync(PermissionDto dto)
        {
            Permission entity = new Permission();

            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.PermissionTypeId = dto.PermissionTypeId;


            await _permissionRepository.Update(entity);

            return dto;
        }

        
    }
}
