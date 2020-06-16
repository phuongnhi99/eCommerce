using eCommerce.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.System.Roles
{
    public interface IRoleSevice
    {
        Task<List<RoleVm>> GetAll();
    }
}
