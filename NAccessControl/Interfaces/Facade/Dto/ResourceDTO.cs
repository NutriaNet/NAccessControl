using NAccessControl.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Interfaces.Facade.Dto
{
    public class ResourceDTO
    {
        public ResourceDTO()
        {
            Permissions = new List<PermissionDTO>();
        }
        public int Id { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }

        public string? ParentKey { get; set; }

        public IEnumerable<PermissionDTO> Permissions { get; set; }
    }
}
