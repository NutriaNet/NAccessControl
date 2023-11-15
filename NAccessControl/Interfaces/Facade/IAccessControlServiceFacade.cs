using NAccessControl.Domain.Model;

namespace NAccessControl.Interfaces.Facade;

public interface IAccessControlServiceFacade
{
    void CreateResources(IEnumerable<Resource> resources);

    void CreatePermission(IEnumerable<Permission> permissions);

    void AssignPermissionsToResource(Resource resource, IEnumerable<Permission> permissions);

    OwnedResource AssignResourcesToRole(Role role, IEnumerable<Resource> resources);

    IEnumerable<Resource> FindAllResources();

    IEnumerable<OwnedResource> FindOwnedResources(IUserId user);
}
