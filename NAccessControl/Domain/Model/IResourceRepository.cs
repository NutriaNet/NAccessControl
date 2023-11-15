namespace NAccessControl.Domain.Model;

public interface IResourceRepository
{
    public IEnumerable<Resource> FindAllResource();

    public IEnumerable<OwnedResource> FindOwnedResources(IUserId user);
}
