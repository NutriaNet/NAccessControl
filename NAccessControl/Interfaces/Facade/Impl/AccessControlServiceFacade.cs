using NAccessControl.Domain.Model;

namespace NAccessControl.Interfaces.Facade.Impl;

public class AccessControlServiceFacade : IAccessControlServiceFacade
{
    private readonly IResourceRepository _resourceRepository;

    public AccessControlServiceFacade(IResourceRepository resourceRepository)
    {
        _resourceRepository = resourceRepository;
    }

    public IEnumerable<Resource> FindAllResources()
    {
        return _resourceRepository.FindAllResource();
    }

    public IEnumerable<OwnedResource> FindOwnedResources(IUserId user)
    {
        return _resourceRepository.FindOwnedResources(user);
    }
}
