namespace NAccessControl.Domain.Model;

public interface IResourceRepository
{

    void Add(Resource resource);

    void AddRange(IEnumerable<Resource> resources);

    Task<int> SaveChangesAsync();

    Task<IEnumerable<Resource>> FindAllResourcesAsync();

    public IEnumerable<OwnedResource> FindOwnedResources(IUserId user);
}
