using NAccessControl.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Service.Impl
{
    public class AccessControlService : IAccessControlService
    {
        private readonly IResourceRepository _resourceRepository;

        public AccessControlService(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }

        public void AssignPermissionsToResource(Resource resource, IEnumerable<Permission> permissions)
        {
            throw new NotImplementedException();
        }

        public OwnedResource AssignResourcesToRole(Role role, IEnumerable<Resource> resources)
        {
            throw new NotImplementedException();
        }

        public void CreatePermission(IEnumerable<Permission> permissions)
        {
            throw new NotImplementedException();
        }

        public void CreateResources(IEnumerable<Resource> resources)
        {
            _resourceRepository.AddRange(resources);
        }

        public async Task<IEnumerable<Resource>> FindAllResourcesAsync()
        {
            return await _resourceRepository.FindAllResourcesAsync();
        }

        public IEnumerable<OwnedResource> FindOwnedResources(IUserId user)
        {
            return _resourceRepository.FindOwnedResources(user);
        }
    }
}
