using Microsoft.AspNetCore.Identity;
using N5.Domain.Dtos;
using System.Threading.Tasks;

namespace N5.Domain.Interfaces.Services
{
    public interface IPermissionService:IService<PermissionDto,int>
    {
        
    }
}
