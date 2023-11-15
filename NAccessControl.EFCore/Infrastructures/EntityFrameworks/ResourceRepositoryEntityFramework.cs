using NAccessControl.Domain.Model;

namespace NAccessControl.EFCore.Infrastructures.EntityFrameworks;

public class ResourceRepositoryEntityFramework : IResourceRepository
{
    public IEnumerable<Resource> FindAllResource()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<OwnedResource> FindOwnedResources(IUserId user)
    {
        throw new NotImplementedException();
    }
}
