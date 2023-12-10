using NAccessControl.Domain.Model;
using NAccessControl.Interfaces.Facade.Assembler;
using NAccessControl.Interfaces.Facade.Command;
using NAccessControl.Interfaces.Facade.Dto;
using NAccessControl.Service;

namespace NAccessControl.Interfaces.Facade.Impl;

public class AccessControlServiceFacade : IAccessControlServiceFacade
{
    private readonly IAccessControlService _accessControlService;
    private readonly ResourceAssember _resourceAssember;

    public AccessControlServiceFacade(IAccessControlService _accessControlService, ResourceAssember _resourceAssember)
    {
        this._accessControlService = _accessControlService;
        this._resourceAssember = _resourceAssember;
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

    public void CreateResources(IEnumerable<CreateResourceCommand> resources)
    {
        _accessControlService.CreateResources(_resourceAssember.CreateCommandToEntity(resources));
    }

    public async Task<IEnumerable<ResourceDTO>> FindAllResourcesAsync()
    {
        return _resourceAssember.EntityToDTO(await _accessControlService.FindAllResourcesAsync());
    }

    public IEnumerable<OwnedResource> FindOwnedResources(IUserId user)
    {
        return _accessControlService.FindOwnedResources(user);
    }
}
