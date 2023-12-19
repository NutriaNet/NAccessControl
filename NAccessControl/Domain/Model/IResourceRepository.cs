namespace NAccessControl.Domain.Model;

public interface IResourceRepository : IRepository<Resource>
{

    Task<IEnumerable<Resource>> FindAllResourcesAsync();

    Task<IEnumerable<OwnedResource>> FindOwnedResourcesAsync(IUserId user);

    Task<IEnumerable<OwnedResource>> FindOwnedResourcesAsync(Role role, string parentKey);

    Task<IEnumerable<OwnedResource>> FindAllOwnedResourcesAsync(Role role);
}
