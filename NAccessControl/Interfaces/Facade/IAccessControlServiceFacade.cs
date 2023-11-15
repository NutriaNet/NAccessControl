using NAccessControl.Domain.Model;

namespace NAccessControl.Interfaces.Facade;

public interface IAccessControlServiceFacade
{
    IEnumerable<Resource> FindAllResources();

    IEnumerable<OwnedResource> FindOwnedResources(IUserId user);
}
