using N5.Domain.Dtos;
using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;
using N5.Domain.Interfaces.Query;
using N5.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace N5.Application.Services
{
    public class EmployeePermissionService:IEmployeePermissionService
    {
        private readonly IEmployeePermissionRepository _employeePermissionRepository;
        private readonly IEmployeePermissionQuery _employeePermissionQuery;
        public EmployeePermissionService(IEmployeePermissionRepository employeePermissionRepository, IEmployeePermissionQuery employeePermissionQuery)
        {
            _employeePermissionRepository = employeePermissionRepository;
            _employeePermissionQuery = employeePermissionQuery;
        }

        public async Task<EmployeePermissionDto> GetAsync(int id)
        {
            EmployeePermissionDto dto = null;
            var entity = await _employeePermissionQuery.GetById(id);

            if (entity != null)
            {
                dto = new EmployeePermissionDto(entity);
            }

            return dto;
        }

        public async Task<EmployeePermissionDto> SaveAsync(EmployeePermissionDto dto)
        {
            var entity = await _employeePermissionRepository.Add(dto.ToEmployeePermission());

            dto.Id = entity.Id;

            return dto;
        }

        public async Task<EmployeePermissionDto> UpdateAsync(EmployeePermissionDto dto)
        {
            var entity = new EmployeePermission();

            entity.Id = dto.Id;
            entity.PermissionId = dto.PermissionId;
            entity.EmployeeId = dto.EmployeeId;

            await _employeePermissionRepository.Update(entity);

            return dto;
        }
    }
}
