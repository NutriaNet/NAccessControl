using NAccessControl.Domain.Model;
using NAccessControl.Interfaces.Facade.Command;
using NAccessControl.Interfaces.Facade.Dto;

namespace NAccessControl.Interfaces.Facade;

public interface IAccessControlServiceFacade
{
    void CreateResources(IEnumerable<CreateResourceCommand> resources);

    void CreatePermission(IEnumerable<Permission> permissions);

    void AssignPermissionsToResource(Resource resource, IEnumerable<Permission> permissions);

    OwnedResourceDTO AssignResourcesToRole(Role role, IEnumerable<Resource> resources);

    Task<IEnumerable<ResourceDTO>> FindAllResourcesAsync();

    Task<IEnumerable<OwnedResourceDTO>> FindOwnedResourcesAsync(FindOwnedResourcesCommand command);
}
