using NAccessControl.Domain.Model;
using NAccessControl.Interfaces.Facade.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Interfaces.Facade.Assembler
{
    public class RoleAssembler
    {
        public RoleDTO EntityToDTO(Role role)
        {
            return new RoleDTO
            {
                Id = role.Id,
                Key = role.Key,
                Name = role.Name,
                CreatedAt = role.CreatedAt,
                UpdatedAt = role.UpdatedAt
            };
        }
    }
}
