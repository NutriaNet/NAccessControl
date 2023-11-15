namespace NAccessControl.Domain.Model;

public interface IResourceRepository
{

    void Add(Resource resource);

    Task<int> SaveChangesAsync();

    Task<IEnumerable<Resource>> FindAllResourceAsync();

    public IEnumerable<OwnedResource> FindOwnedResources(IUserId user);
}
