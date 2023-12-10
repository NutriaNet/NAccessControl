using NAccessControl.Domain.Model;
using NAccessControl.Interfaces.Facade.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Interfaces.Facade.Assembler
{
    public class PermissionAssember
    {
        public PermissionDTO EntityToDTO(Permission command)
        {
            return new PermissionDTO
            {
                Id = command.Id, 
                Key = command.Key,
                Name = command.Name 
            };
        }

        public IEnumerable<PermissionDTO> EntityToDTO(IEnumerable<Permission> resources)
        {
            return resources.Select(c => this.EntityToDTO(c));
        }
    }
}
