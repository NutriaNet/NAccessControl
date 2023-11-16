namespace NAccessControl.Domain.Model;

public interface IResourceRepository : IRepository<Resource>
{

    Task<IEnumerable<Resource>> FindAllResourcesAsync();

    public IEnumerable<OwnedResource> FindOwnedResources(IUserId user);
}
