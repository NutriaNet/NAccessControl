using NAccessControl.Domain.Model;
using NAccessControl.Interfaces.Facade.Command;
using NAccessControl.Interfaces.Facade.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Interfaces.Facade.Assembler
{
    public class ResourceAssember
    {
        private readonly PermissionAssember _permissionAssember;
        public ResourceAssember(PermissionAssember permissionAssember)
        {
            this._permissionAssember = permissionAssember;
        }
        public Resource CreateCommandToEntity(CreateResourceCommand command)
        {
            return new Resource
            {
                ParentId = command.ParentId,
                Key = command.Key,
                Name = command.Name,
                ParentKey = command.ParentKey,
            };
        }

        public IEnumerable<Resource> CreateCommandToEntity(IEnumerable<CreateResourceCommand> resources)
        {
            return resources.Select(c => this.CreateCommandToEntity(c));
        }

        public ResourceDTO EntityToDTO(Resource command)
        {
            return new ResourceDTO
            {
                Id = command.Id,
                ParentId = command.ParentId,
                Key = command.Key,
                Name = command.Name,
                ParentKey = command.ParentKey,
                Permissions = _permissionAssember.EntityToDTO(command.Permissions),
            };
        }

        public IEnumerable<ResourceDTO> EntityToDTO(IEnumerable<Resource> resources)
        {
            return resources.Select(c => this.EntityToDTO(c));
        }
    }
}
