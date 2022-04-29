using N5.Domain.Dtos;
using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;
using N5.Domain.Interfaces.Query;
using N5.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace N5.Application.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeQuery _employeeQuery;
        public EmployeeService(IEmployeeRepository employeeRepository, IEmployeeQuery employeeQuery)
        {
            _employeeRepository = employeeRepository;
            _employeeQuery = employeeQuery;
        }        

        

        public async Task<EmployeeDto> SaveAsync(EmployeeDto dto)
        {
            var entity = await _employeeRepository.Add(dto.ToEmployee());

            dto.Id = entity.Id;

            return dto;
        }

        public async  Task<EmployeeDto> GetAsync(int id)
        {
            EmployeeDto dto = null;
            var entity = await _employeeQuery.GetById(id);

            if (entity != null)
            {
                dto = new EmployeeDto(entity);
            }

            return dto;
        }

        public async Task<EmployeeDto> UpdateAsync(EmployeeDto dto)
        {
            var entity = new Employee();

            entity.Id = dto.Id;
            entity.FirstName = dto.FirstName;
            entity.LastName = dto.LastName;
            entity.Email = dto.Email;

            await _employeeRepository.Update(entity);

            return dto;
        }
    }
}
