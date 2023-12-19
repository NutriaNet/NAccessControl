using NAccessControl.Domain.Model;
using NAccessControl.Interfaces.Facade.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Interfaces.Facade.Assembler
{
    public class OwnedResourceAssembler
    {
        private readonly ResourceAssember _resourceAssember;
        private readonly PermissionAssember _permissionAssember;
        private readonly RoleAssembler _roleAssembler;
        public OwnedResourceAssembler(ResourceAssember resourceAssember,
            PermissionAssember permissionAssember,
            RoleAssembler roleAssembler)
        {
            _resourceAssember = resourceAssember;
            _permissionAssember = permissionAssember;
            _roleAssembler = roleAssembler;
        }


        public OwnedResourceDTO EntityToDTO(OwnedResource command)
        {
            return new OwnedResourceDTO
            {
                Id = command.Id,
                RoleId = command.RoleId,
                Role = _roleAssembler.EntityToDTO(command.Role),
                Resource = _resourceAssember.EntityToDTO(command.Resource),
                Permissions = _permissionAssember.EntityToDTO(command.Permissions)
            };
        }

        public IEnumerable<OwnedResourceDTO> EntityToDTO(IEnumerable<OwnedResource> resources)
        {
            return resources.Select(c => this.EntityToDTO(c));
        }
    }
}
