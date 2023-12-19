using NAccessControl.Domain.Model;
using NAccessControl.Interfaces.Facade.Assembler;
using NAccessControl.Interfaces.Facade.Command;
using NAccessControl.Interfaces.Facade.Dto;
using NAccessControl.Service;
using System.Collections.Generic;

namespace NAccessControl.Interfaces.Facade.Impl;

public class AccessControlServiceFacade : IAccessControlServiceFacade
{
    private readonly IAccessControlService _accessControlService;
    private readonly ResourceAssember _resourceAssember;
    private readonly OwnedResourceAssembler _ownedResourceAssembler;
    private readonly UserIdAssembler userIdAssembler;

    public AccessControlServiceFacade(IAccessControlService _accessControlService,
        ResourceAssember _resourceAssember,
        OwnedResourceAssembler ownedResourceAssembler,
        UserIdAssembler userIdAssembler)
    {
        this._accessControlService = _accessControlService;
        this._resourceAssember = _resourceAssember;
        this._ownedResourceAssembler = ownedResourceAssembler;
        this.userIdAssembler = userIdAssembler;
    }

    public void AssignPermissionsToResource(Resource resource, IEnumerable<Permission> permissions)
    {
        throw new NotImplementedException();
    }

    public OwnedResourceDTO AssignResourcesToRole(Role role, IEnumerable<Resource> resources)
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

    public async Task<IEnumerable<OwnedResourceDTO>> FindOwnedResourcesAsync(FindOwnedResourcesCommand command)
    {
        return _ownedResourceAssembler.EntityToDTO(await _accessControlService.FindOwnedResourcesAsync(this.userIdAssembler.ToEntity(command)));
    }
}
