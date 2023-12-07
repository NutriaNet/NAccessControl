using NAccessControl.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Service
{
    public interface IAccessControlService
    {
        void CreateResources(IEnumerable<Resource> resources);

        void CreatePermission(IEnumerable<Permission> permissions);

        void AssignPermissionsToResource(Resource resource, IEnumerable<Permission> permissions);

        OwnedResource AssignResourcesToRole(Role role, IEnumerable<Resource> resources);

        IEnumerable<Resource> FindAllResources();

        IEnumerable<OwnedResource> FindOwnedResources(IUserId user);
    }
}
