using NAccessControl.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Interfaces.Facade.Dto
{
    public class OwnedResourceDTO
    {
        public int Id { get; set; }

        public RoleDTO Role { get; set; }

        public int RoleId { get; set; } 

        public ResourceDTO Resource { get; set; }

        public IEnumerable<PermissionDTO> Permissions { get; set; }
    }
}
