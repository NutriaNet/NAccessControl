using NAccessControl.Domain.Model;

namespace NAccessControl.Interfaces.Facade.Impl;

public class AccessControlServiceFacade : IAccessControlServiceFacade
{
    private readonly IResourceRepository _resourceRepository;

    public AccessControlServiceFacade(IResourceRepository resourceRepository)
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
        throw new NotImplementedException();
    }

    public IEnumerable<Resource> FindAllResources()
    {
        return _resourceRepository.FindAllResourceAsync();
    }

    public IEnumerable<OwnedResource> FindOwnedResources(IUserId user)
    {
        return _resourceRepository.FindOwnedResources(user);
    }
}
